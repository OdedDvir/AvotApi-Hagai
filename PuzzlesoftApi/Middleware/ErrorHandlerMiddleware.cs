using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using B3.Extensions.Data;
using ElmahCore;
using Google.Authenticator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;
using PuzzlesoftApi.Services;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Task = System.Threading.Tasks.Task;

namespace PuzzlesoftApi.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlerMiddleware> _logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value.Contains("elmah"))
            {
                await _next(context);
                return;
            }
            var bodyStream = context.Response.Body;
            context.Response.ContentType = "application/json";
            try
            {
                string json;
                using (var mem = new MemoryStream())
                {
                    context.Response.Body = mem;
                    await _next(context);
                    mem.Position = 0;
                    json = new StreamReader(mem).ReadToEnd();
                }

                Dictionary<string, object> respObj;
                try
                {
                    respObj = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                }
                catch (JsonSerializationException)
                {
                    try
                    {
                        respObj = new Dictionary<string, object>()
                        {
                            {"value", JsonConvert.DeserializeObject<List<object>>(json)}
                        };
                    }
                    catch (JsonSerializationException)
                    {
                        respObj = new Dictionary<string, object>
                        {
                            {"value", json}
                        };
                    }
                }
                if (respObj == null)
                    return;
                respObj["error_code"] = "100";
                respObj["error_message"] = string.Empty;
                var buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(respObj));
                context.Response.ContentLength = buffer.Length;
                using (var output = new MemoryStream(buffer)) {
                    await output.CopyToAsync(bodyStream);
                }
                _logger.LogInformation("Request {method} {url} => {statusCode}",
                    context.Request?.Method,
                    context.Request?.Path.Value,
                    context.Response?.StatusCode);
            }
            catch (Exception error)
            {
                context.Response.Body = bodyStream;
                var response = context.Response;
                if (!(error is PuzzlesoftGlobalError))
                {
                    try
                    {
                        response.StatusCode = (int) HttpStatusCode.BadRequest;
                    }
                    catch (Exception)
                    {}

                    error.Data["exception"] = error.ToString();
                    context.RiseError(error);
                }
                await response.WriteAsJsonAsync(error.Data);
            }
            finally
            {
                context.Response.Body = bodyStream;
            }
        }
    }
}
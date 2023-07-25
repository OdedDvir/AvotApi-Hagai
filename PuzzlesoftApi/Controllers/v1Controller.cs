using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using B3.Extensions.Data;
using Google.Authenticator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;
using PuzzlesoftApi.Services;
using Task = System.Threading.Tasks.Task;

namespace PuzzlesoftApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class V1Controller : ControllerBase
    {
        private readonly string _anotherApiUrl;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ITotlService _totl;

        public V1Controller(IHttpClientFactory httpClientFactory, IConfiguration configuration, ITotlService totl)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _totl = totl;
            _anotherApiUrl = configuration.GetSection("AnotherApiUrl").Value;
        }

        private async Task<string> Proxy(HttpMethod method, string uri, string token, object args)
        {
            var req = new HttpRequestMessage(method, _anotherApiUrl + uri);
            if (args != null)
                req.Content = new StringContent(JsonSerializer.Serialize(args), Encoding.UTF8, "application/json");
            if (!string.IsNullOrWhiteSpace(token))
                req.Headers.TryAddWithoutValidation("Authorization", token);

            var client = _httpClientFactory.CreateClient();
            var resp = await client.SendAsync(req);
            HttpContext.Response.StatusCode = (int)resp.StatusCode;
            HttpContext.Response.Headers.Add(HeaderNames.ContentType, "application/json");
            string content = await resp.Content.ReadAsStringAsync();
            await HttpContext.Response.WriteAsync(content);
            return content;
        }
        
        [HttpPost("mfaverify")]
        public async Task MFAPost([FromHeader(Name="Authorization")]string token,[FromBody] MFACode code)
        {
            await Proxy(HttpMethod.Post, "/prod/mfaverify", token, code);
        }

        [HttpPost("auth")]
        public async Task Post([FromBody] UserCredentials cred)
        {
            await Proxy(HttpMethod.Post, "/prod/auth", null, cred);
        }

        [HttpPost("ret_data_to_client_to_shikum")]
        public async Task RetDataToClientToShikum([FromHeader(Name="Authorization")]string token,[FromBody]RetDataToClientToShikumArgs args)
        {
            await Proxy(HttpMethod.Post, "/prod/ret_data_to_client_to_shikum", token, args);
        }

        [HttpPost("add_rep_to_follow")]
        public async Task AddRepToFollow([FromHeader(Name="Authorization")]string token,[FromBody]AddRepToFollowArgs args)
        {
            await Proxy(HttpMethod.Post, "/prod/add_rep_to_follow", token, args);
        }
        
        [HttpDelete("del_rep_to_follow")]
        public async Task DelRepToFollow([FromHeader(Name="Authorization")]string token,[FromBody]DelRepToFollowArgs args)
        {
            await Proxy(HttpMethod.Delete, "/prod/del_rep_to_follow", token, args);
        }

        [HttpGet("resend")]
        public async Task Resend([FromHeader(Name="Authorization")]string token)
        {
            await Proxy(HttpMethod.Get, "/prod/resend", token, null);

        }

    }

}
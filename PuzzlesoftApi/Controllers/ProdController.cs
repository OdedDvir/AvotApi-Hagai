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
    public class ProdController : ControllerBase
    {
        private readonly string _lanApiUrl;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ITotlService _totl;
        private readonly ILogger<ProdController> _logger;

        public ProdController(IHttpClientFactory httpClientFactory, IConfiguration configuration, ITotlService totl, ILogger<ProdController> logger)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _totl = totl;
            _logger = logger;
            _lanApiUrl = configuration.GetSection("LanApiUrl").Value;
        }

        private async Task<string> Proxy(HttpMethod method, string uri, string token, object args)
        {
            var req = new HttpRequestMessage(method, _lanApiUrl + uri);
            if (args != null)
            {
                var body = JsonSerializer.Serialize(args);
                _logger.LogInformation(_lanApiUrl + uri + " => " + body);
                req.Content = new StringContent(body, Encoding.UTF8, "application/json");
            }

            if (!string.IsNullOrWhiteSpace(token))
            {
                req.Headers.TryAddWithoutValidation("Authorization", token);
                _logger.LogInformation(token);
            }

            using var client = _httpClientFactory.CreateClient();
            var resp = await client.SendAsync(req);
            HttpContext.Response.StatusCode = (int)resp.StatusCode;
            HttpContext.Response.Headers.Add(HeaderNames.ContentType, "application/json");
            string content = await resp.Content.ReadAsStringAsync();
            _logger.LogInformation(_lanApiUrl + uri + " <= " + content);
            await HttpContext.Response.WriteAsync(content);
            return content;
        }
        
        [HttpPost("mfaverify")]
        public async Task<PuzzleResponse<CustomToken>> MFAPost([FromHeader(Name="Authorization")]string token,[FromBody] MFACode code)
        {
            return await Task.Run(() =>
            {
                AuthPayload payload;
                try
                {
                    payload = AuthSecret.DecryptToken(token);
                }
                catch (Exception)
                {
                    return Helper.ReturnError<CustomToken>(ServerErrors.AuthenticationFailed);
                }
                if (payload.Expiration < DateTime.Now)
                    return Helper.ReturnError<CustomToken>(ServerErrors.AuthenticationFailed);
                bool hasSucceeded;
                if (payload.MFAMethod == AuthMethods.GoogleAuth)
                {
                    hasSucceeded = new TwoFactorAuthenticator().ValidateTwoFactorPIN(
                        AuthSecret.AccountSecret(payload.UserId.ToString()),
                        code.Code);
                }
                else
                {
                    hasSucceeded = _totl.CheckTotl(payload.UserId.ToString(), code.Code);
                }

                if (!hasSucceeded)
                    return Helper.ReturnError<CustomToken>(ServerErrors.InvalidMfaCode);

                payload.hasMFAEnabled = true;
                return new PuzzleResponse<CustomToken>()
                {
                    Response = new CustomToken()
                    {
                        Expiration = payload.Expiration,
                        Token = AuthSecret.EncryptToken(payload)
                    }
                };
            });
        }

        [HttpPost("auth")]
        public async Task Post([FromBody] UserCredentials cred)
        {
            var resp = await Proxy(HttpMethod.Post, "/user/auth", null, cred);
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<PuzzleResponse<CustomToken>>(resp);
            _logger.LogInformation("Resp is: " + resp);
            if (response.ErrorCode != "100" || response.Response == null)
                return;
            var req = new HttpRequestMessage(HttpMethod.Get, _lanApiUrl + "/user/get_phone");
            req.Headers.TryAddWithoutValidation("Authorization", response.Response?.Token);
            using var client = _httpClientFactory.CreateClient();
            var phoneResp = await client.SendAsync(req);
            var phoneNumber = await phoneResp.Content.ReadAsStringAsync();
            SetupCode setupCode = null;
            if (cred.AuthMethod == AuthMethods.GoogleAuth)
            {
                setupCode = new TwoFactorAuthenticator().GenerateSetupCode("פאזלסופט",
                    response.Response.UserDetails.UserFName,
                    AuthSecret.AccountSecret(response.Response.UserDetails.UserId.ToString()), false);
            }
            else
            {
                var code = _totl.CreateTotl(response.Response.UserDetails.UserId.ToString());
                var s = await SmsService.SendSms(phoneNumber.Replace("-", ""),
                    string.Format(_configuration.GetValue<string>("ApiSettings:SmsMessage"), code));
                _logger.LogInformation(s);
            }
        }

        [HttpPost("ret_data_to_client_to_shikum")]
        public async Task RetDataToClientToShikum([FromHeader(Name="Authorization")]string token,[FromBody]RetDataToClientToShikumArgs args)
        {
            await Proxy(HttpMethod.Post, "/user/ret_data_to_client_to_shikum", token, args);
        }

        [HttpPost("add_rep_to_follow")]
        public async Task AddRepToFollow([FromHeader(Name="Authorization")]string token,[FromBody]AddRepToFollowArgs args)
        {
            await Proxy(HttpMethod.Post, "/user/add_rep_to_follow", token, args);
        }
        
        [HttpDelete("del_rep_to_follow")]
        public async Task DelRepToFollow([FromHeader(Name="Authorization")]string token,[FromBody]DelRepToFollowArgs args)
        {
            await Proxy(HttpMethod.Delete, "/user/del_rep_to_follow", token, args);
        }

        [HttpGet("resend")]
        public async Task Resend([FromHeader(Name="Authorization")]string token)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, _lanApiUrl + "/user/get_phone");
            req.Headers.TryAddWithoutValidation("Authorization", token);
            var client = _httpClientFactory.CreateClient();
            var resp = await client.SendAsync(req);
            var phoneNumber = await resp.Content.ReadAsStringAsync();
            var id = AuthSecret.DecryptToken(token).UserId;
            var code = _totl.CreateTotl(id.ToString());
            
            var s = await SmsService.SendSms(phoneNumber.Replace("-", ""),
                string.Format(_configuration.GetValue<string>("ApiSettings:SmsMessage"), code));
            _logger.LogInformation(s);
            await Response.WriteAsync(s);
        }
        
        [HttpPost("medical_query")]
        public async Task MedicalQuery([FromHeader(Name="Authorization")]string token, [FromBody]MedicalQueryParams args)
        {
            await Proxy(HttpMethod.Post, "/user/medical_query", token, args);
        }

    }

}
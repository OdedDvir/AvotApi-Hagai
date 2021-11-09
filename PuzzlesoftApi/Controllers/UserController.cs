using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using B3.Extensions.Data;
using Google.Authenticator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;
using PuzzlesoftApi.Services;
using Task = System.Threading.Tasks.Task;

namespace PuzzlesoftApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly dbcompdemoContext _context;
        private readonly ITotlService _totl;
        private readonly ILogger<UserController> _logger;
        private readonly IConfiguration _configuration;
        
        public UserController(dbcompdemoContext context, ITotlService totl, ILogger<UserController> logger, IConfiguration configuration)
        {
            _context = context;
            _totl = totl;
            _logger = logger;
            _configuration = configuration;
        }

        [HttpPost("mfaverify")]
        public CustomToken MFAPost([FromBody] string code)
        {
            AuthPayload payload = AuthSecret.DecryptToken(Request.Headers["Authorization"]);
            if (payload.Expiration < DateTime.Now)
                return null;
            if (payload.MFAMethod == AuthMethods.GoogleAuth)
            {
                if (!new TwoFactorAuthenticator().ValidateTwoFactorPIN(
                    AuthSecret.AccountSecret(payload.UserId.ToString()),
                    code.ToString()))
                    return null;
            }
            else
            {
                // will throw error if invalid
                _totl.CheckTotl(payload.UserId.ToString(), code);
            }

            payload.hasMFAEnabled = true;
            return new CustomToken()
            {
                Expiration = payload.Expiration,
                Token = AuthSecret.EncryptToken(payload)
            };
        }

        [HttpPost("auth")]
        public async Task<CustomToken> Post([FromBody] UserCredentials cred)
        {
            IsUserInSystemArgs args = new IsUserInSystemArgs {UserName = cred.Username, UserPass = cred.Password};
            var userRow = _context.ExecuteProc("pr_IsUserInSystem", args)["Table"][0];
            ClientDetail cd = await _context.ClientDetails.FindAsync(userRow["UserId"]);
            if (cd == null)
                return null;
            DateTime expiration = DateTime.Now.Add(TimeSpan.FromMinutes(_configuration.GetValue<int>("ApiSettings:MinutesToTokenExpiration")));
            var authPayload = new AuthPayload()
            {
                Expiration = expiration,
                ProfileId = cd.UserProfileId,
                UserId = cd.Id,
                UserName = cd.NameView,
                hasMFAEnabled = false,
                MFAMethod = cred.AuthMethod
            };
            var token = AuthSecret.EncryptToken(authPayload);
            SetupCode setupCode = null; 
            if (cred.AuthMethod == AuthMethods.GoogleAuth)
            {
                setupCode = new TwoFactorAuthenticator().GenerateSetupCode("פאזלסופט", cd.NameView,
                    AuthSecret.AccountSecret(cd.Id.ToString()), false);
            }
            else
            {
                var code = _totl.CreateTotl(cd.Id.ToString());

                var s = await SmsService.SendSms(cd,
                    string.Format(_configuration.GetValue<string>("ApiSettings:SmsMessage"), code));
                _logger.LogDebug(s);
            }

            return new CustomToken()
            {
                Token = token,
                Expiration = expiration,
                QRCodeUrl = setupCode?.QrCodeSetupImageUrl,
                UserDetails = userRow
            };
        }

        [Authorize]
        [HttpPost("ret_data_to_client_to_shikum")]
        public Dictionary<string,List<Dictionary<string, object>>> RetDataToClientToShikum([FromBody]RetDataToClientToShikumArgs args)
        {
            return _context.ExecuteProc("pr_RetDataToClientToShikum", args, User);
        }

        [Authorize]
        [HttpPost("add_rep_to_follow")]
        public object AddRepToFollow([FromBody]AddRepToFollowArgs args)
        {
            return _context.ExecuteProcAndGetValue("pr_AddRepToFollow", args, User);
        }
        
        [Authorize]
        [HttpDelete("del_rep_to_follow")]
        public object DelRepToFollow([FromBody]DelRepToFollowArgs args)
        {
            return _context.ExecuteProcAndGetValue("pr_DelRepToFollow", args, User);
        }
        
        [HttpGet("test")]
        public object Test()
        {
            throw new PuzzlesoftGlobalError
            {
                Data =
                {
                    {"error_code", "123"},
                    {"error_message", "this is a test message"}
                }
            };
        }

        [HttpGet("resend")]
        async public Task Resend()
        {
            var payload = AuthSecret.DecryptToken(Request.Headers["Authorization"]);
            var cd = _context.ClientDetails.Find(payload.UserId);
            var code = _totl.CreateTotl(cd.Id.ToString());

            var s = await SmsService.SendSms(cd,
                string.Format(_configuration.GetValue<string>("ApiSettings:SmsMessage"), code));
            _logger.LogDebug(s);
        }

        public class IsUserInSystemArgs
        {
            public string UserName { get; set; }
            public string UserPass { get; set; }
        }
        public class RetDataToClientToShikumArgs
        {
            public string Idcard { get; set; }
            [UserId]
            public int UserId { get; set; }
        }
        public class AddRepToFollowArgs     
        {
            public int ClientID { get; set; }
            public string Date1 { get; set; }
            public string Time1 { get; set; }
            public string Val1 { get; set; }
            public string Comments { get; set; }
            public int[]  SubjectID { get; set; }
            [UserId]
            public int UserId { get; set; }
        }

        public class DelRepToFollowArgs
        {
            public int ID { get; set; }
            [UserId]
            public int UserId { get; set; }
        }
    }
}
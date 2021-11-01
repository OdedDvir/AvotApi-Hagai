using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
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
        private readonly IUserService _userService;
        private readonly dbcompdemoContext _context;
        private readonly ITotlService _totl;
        private readonly ILogger<UserController> _logger;
        
        public UserController(IUserService userService, dbcompdemoContext context, ITotlService totl, ILogger<UserController> logger)
        {
            _userService = userService;
            _context = context;
            _totl = totl;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ValueTask<ClientDetail> Get(int id)
        {
            return _userService.GetUserByIdAsync(id);
        }

        [HttpGet]
        public Task<ClientDetail[]> GetAll(int id)
        {
            return _userService.GetAllUsersAsync();
        }

        [HttpPost("mfaverify")]
        public CustomToken MFAPost([FromBody] string code)
        {
            try
            {
                AuthPayload payload = AuthSecret.DecryptToken(Request.Headers["Authorization"]);
                if (payload.Expiration < DateTime.Now)
                    return null;
                if (false)
                {
                    if (!new TwoFactorAuthenticator().ValidateTwoFactorPIN(
                        AuthSecret.AccountSecret(payload.UserId.ToString()),
                        code.ToString()))
                        return null;
                }
                else
                {
                    if (!_totl.CheckTotl(payload.UserId.ToString(), code))
                    {
                        return null;
                    }
                }

                payload.hasMFAEnabled = true;
                return new CustomToken()
                {
                    Expiration = payload.Expiration,
                    Token = AuthSecret.EncryptToken(payload)
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost("auth")]
        public async Task<CustomToken> Post([FromBody] UserCredentials cred)
        {
            ClientDetail cd = await _userService.GetUserByCredentialsAsync(cred);
            if (cd == null)
                return null;
            DateTime expiration = DateTime.Now.Add(TimeSpan.FromDays(1));
            var authPayload = new AuthPayload()
            {
                Expiration = expiration,
                ProfileId = cd.UserProfileId,
                UserId = cd.Id,
                UserName = cd.NameView,
                hasMFAEnabled = false
            };
            var token = AuthSecret.EncryptToken(authPayload);
            if (cred.AuthMethod == AuthMethods.GoogleAuth)
            {
                var setupCode = new TwoFactorAuthenticator().GenerateSetupCode("פאזלסופט", cd.NameView,
                    AuthSecret.AccountSecret(cd.Id.ToString()), false);
            }
            else
            {
                var code = _totl.CreateTotl(cd.Id.ToString());

                var s = await SmsService.SendSms(cd.Phone1.Coalesce(cd.Phone2, cd.Phone3, cd.Phone4),
                    $"להשלמת ההתחברות, אנא הכניסו את הקוד הבא: {code} \r\nשימו לב, הקוד תקף ל-5 דקות");
                _logger.LogDebug(s);
            }

            return new CustomToken()
            {
                Token = token,
                Expiration = expiration,
                //QRCodeUrl = setupCode.QrCodeSetupImageUrl // for the meantime.
            };
        }
        
        [Authorize]
        [HttpPost("is_user_in_system")]
        public List<Dictionary<string, object>> IsUserInSystem([FromBody] IsUserInSystemArgs args)
        {
            return _context.ExecuteProc("pr_IsUserInSystem", args)["Table"];
        }
        
        [Authorize]
        [HttpPost("ret_data_to_client_to_shikum")]
        public Dictionary<string,List<Dictionary<string, object>>> RetDataToClientToShikum([FromBody]RetDataToClientToShikumArgs args)
        {
            return _context.ExecuteProc("pr_RetDataToClientToShikum", args);
        }

        [Authorize]
        [HttpPost("add_rep_to_follow")]
        public object AddRepToFollow([FromBody]AddRepToFollowArgs args)
        {
            return _context.ExecuteProcAndGetValue("pr_AddRepToFollow", args);
        }
        
        [Authorize]
        [HttpDelete("del_rep_to_follow")]
        public object DelRepToFollow([FromBody]DelRepToFollowArgs args)
        {
            return _context.ExecuteProcAndGetValue("pr_DelRepToFollow", args);
        }

        public class IsUserInSystemArgs
        {
            public string UserName { get; set; }
            public string UserPass { get; set; }
        }
        public class RetDataToClientToShikumArgs
        {
            public string Idcard { get; set; }
            public int UserId { get; set; }
        }
        public class AddRepToFollowArgs
        {
            public int ClientID { get; set; }
            public string Date1 { get; set; }
            public string Time1 { get; set; }
            public string Val1 { get; set; }
            public string Comments { get; set; }
            public string  SubjectID { get; set; }
            public string SubjectID2 { get; set; }
            public string SubjectID3 { get; set; }
            public string SubjectID4 { get; set; }
            public int UserId { get; set; }
        }

        public class DelRepToFollowArgs
        {
            public int ID { get; set; }
            public int UserId { get; set; }
        }
    }
}
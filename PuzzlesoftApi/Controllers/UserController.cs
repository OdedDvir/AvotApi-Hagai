using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Google.Authenticator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public UserController(IUserService userService, dbcompdemoContext context)
        {
            _userService = userService;
            _context = context;
        } 
        [HttpGet("{id}")]
        public ValueTask<ClientDetail> Get(int id)
        {
            return _userService.GetUserByIdAsync(id);
        }
        [Authorize]
        [HttpGet]
        public Task<ClientDetail[]> GetAll(int id)
        {
            return _userService.GetAllUsersAsync();
        }

        [HttpPost("mfaverify")]
        public CustomToken MFAPost([FromBody]int code)
        {
            try
            {
                AuthPayload payload = null;
                payload = AuthSecret.DecryptToken(Request.Headers["Authorization"]);
                if (payload.Expiration < DateTime.Now)
                    return null;
                if (!new TwoFactorAuthenticator().ValidateTwoFactorPIN(
                    AuthSecret.AccountSecret(payload.UserId.ToString()),
                    code.ToString()))
                    return null;
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
                hasMFAEnabled = true // for the meantime.
            };
            var token = AuthSecret.EncryptToken(authPayload);
            /* // for the meantime.
            var setupCode = new TwoFactorAuthenticator().GenerateSetupCode("פאזלסופט", cd.NameView,
                AuthSecret.AccountSecret(cd.Id.ToString()), false);
                */
            return new CustomToken()
            {
                Token = token,
                Expiration = expiration,
                //QRCodeUrl = setupCode.QrCodeSetupImageUrl // for the meantime.
            };
        }

        public async Task<Dictionary<string, object>> IsUserExists([FromBody] UserCredentials cred)
        {
            try
            {
                ClientDetail cd = await _userService.GetUserByCredentialsAsync(cred);
                if (cd == null)
                    return null;
                var medicalGroup =
                    await _context.TblDefMedicalGroups.FirstOrDefaultAsync(mg => mg.Id == cd.MedicalGroupId);
                return new Dictionary<string, object>()
                {
                    {"IsSuccess", true},
                    {"UserId", cd.Id},
                    {"MedicalGroupId", cd.MedicalGroupId},
                    {"MedicalGroupName", medicalGroup.Item},
                    {"FollowId", medicalGroup.FollowId},
                    {"UserName", cd.WorkerUserName}
                };
            }
            catch (Exception)
            {
                return new Dictionary<string, object>()
                {
                    {"IsSuccess", false},
                    {"UserId", null},
                    {"MedicalGroupId", null},
                    {"MedicalGroupName", null},
                    {"FollowId", null},
                    {"UserName", null}
                };
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Google.Authenticator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public ClientDetail Get(int id)
        {
            using (var ctx = new dbcompdemoContext())
            {
                return ctx.ClientDetails.Find(id);
            }
        }
        [Authorize]
        public IEnumerable<ClientDetail> GetAll(int id)
        {
            using (var ctx = new dbcompdemoContext())
            {
                return ctx.ClientDetails.ToList();
            }
        }

        [HttpPost("mfaverify")]
        public CustomToken MFAPost([FromBody]int code)
        {
            AuthPayload payload = null;
            try
            {
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
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpPost("auth")]
        public CustomToken Post([FromBody] UserCredentials cred)
        {
            using (var ctx = new dbcompdemoContext())
            {
                ClientDetail cd = ctx.ClientDetails.FirstOrDefault(u =>
                    u.WorkerUserName == cred.Username &&
                    u.Password == cred.Password);
                if (cd == null)
                    return null;
                DateTime expiration = DateTime.Now.Add(TimeSpan.FromDays(1));
                var AuthPayload = new AuthPayload()
                {
                    Expiration = expiration,
                    ProfileId = cd.UserProfileId,
                    UserId = cd.Id,
                    UserName = cd.NameView
                };
                var token = AuthSecret.EncryptToken(AuthPayload);
                var setupCode = new TwoFactorAuthenticator().GenerateSetupCode("פאזלסופט", cd.NameView,
                    AuthSecret.AccountSecret(cd.Id.ToString()), false);
                return new CustomToken()
                {
                    Token = token,
                    Expiration = expiration,
                    QRCodeUrl = setupCode.QrCodeSetupImageUrl
                };
            }
        }
    }
}
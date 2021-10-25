using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
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
                var crypt = new AesManaged()
                {
                    Key = AuthSecret.Key,
                    IV = AuthSecret.IV
                };
                var buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize<AuthPayload>(AuthPayload));
                var token = Convert.ToBase64String(
                    crypt.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length)
                );
                return new CustomToken()
                {
                    Token = token,
                    Expiration = expiration
                };
            }
        }
    }
}
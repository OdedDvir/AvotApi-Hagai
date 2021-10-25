using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using PuzzlesoftApi.Model;
using Task = System.Threading.Tasks.Task;
using JsonProp = Newtonsoft.Json.JsonPropertyAttribute; 

namespace PuzzlesoftApi.Auth
{
    public class MyCustomTokenAuthOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScemeName = "AuthScheme";
    }

    public class MyCustomTokenAuthHandler : AuthenticationHandler<MyCustomTokenAuthOptions>
    {
        public MyCustomTokenAuthHandler(IOptionsMonitor<MyCustomTokenAuthOptions> options, ILoggerFactory logger,
            UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            AuthPayload payload = null;
            try
            {
                var buffer = Convert.FromBase64String(Request.Headers["Authorization"]);
                var crypt = new AesManaged()
                {
                    Key = AuthSecret.Key,
                    IV = AuthSecret.IV
                };
                payload = JsonSerializer.Deserialize<AuthPayload>(
                    Encoding.UTF8.GetString(
                        crypt.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length)
                    )
                );
                if (payload.Expiration < DateTime.Now)
                    return Task.FromResult(AuthenticateResult.Fail("token expired"));
            }
            catch (Exception e)
            {
                return Task.FromResult(AuthenticateResult.Fail(e));
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, payload.UserId.ToString()),
                new Claim(ClaimTypes.Name, payload.UserName),
                new Claim("ProfileId", payload.ProfileId?.ToString()),
            };
            var id = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(id);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
    public class UserCredentials
    {
        [JsonProp("username")]
        public string Username { get; set; }
        [JsonProp("password")]
        public string Password { get; set; }
    }

    public class CustomToken
    {
        [JsonProp("token")]
        public string Token { get; set; }
        [JsonProp("expiration")]
        public DateTime Expiration { get; set; }
    }

    public class AuthPayload
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? ProfileId { get; set; }
        public DateTime Expiration { get; set; }
    }

    public static class AuthSecret
    {
        public static byte[] Key = new byte[32]
        {
            245, 126, 170, 191, 40, 224, 251, 175, 193, 48, 129, 85, 55, 170, 173, 5, 140, 32, 132, 10, 54, 24, 61, 228,
            23, 25, 136, 56, 145, 13, 137, 154
        };

        public static byte[] IV = new byte[16]
            {157, 105, 83, 121, 56, 252, 173, 130, 209, 91, 210, 7, 153, 103, 155, 196};
    }
}
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
    public class AuthOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScemeName = "AuthScheme";
    }

    public class AuthTokenHandler : AuthenticationHandler<AuthOptions>
    {
        public AuthTokenHandler(IOptionsMonitor<AuthOptions> options, ILoggerFactory logger,
            UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            AuthPayload payload = null;
            try
            {
                payload = AuthSecret.DecryptToken(Request.Headers["Authorization"]);
                if (payload.Expiration < DateTime.Now)
                    return Task.FromResult(AuthenticateResult.Fail("token expired"));
                if (!payload.hasMFAEnabled)
                    return Task.FromResult(
                        AuthenticateResult.Fail("authentication process was not completed by the user"));
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
        [JsonProp("auth_method")]

        public string AuthMethod { get; set; } = AuthMethods.SmsAuth;
    }
    public static class AuthMethods
    {
        public const string GoogleAuth = "google_auth";
        public const string SmsAuth = "sms_auth";
    }

    public class CustomToken
    {
        [JsonProp("token")]
        public string Token { get; set; }
        [JsonProp("expiration")]
        public DateTime Expiration { get; set; }
        public string QRCodeUrl { get; set; }
    }

    public class AuthPayload
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? ProfileId { get; set; }
        public DateTime Expiration { get; set; }
        public bool hasMFAEnabled { get; set; }
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

        public static string AccountSecret(string account)
        {
            return $"PUZZLESECRET{account}";
        }

        public static AuthPayload DecryptToken(string base64buffer)
        {
            var buffer = Convert.FromBase64String(base64buffer);
            var crypt = new AesManaged()
            {
                Key = AuthSecret.Key,
                IV = AuthSecret.IV
            };
            var payload = JsonSerializer.Deserialize<AuthPayload>(
                Encoding.UTF8.GetString(
                    crypt.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length)
                )
            );
            return payload;
        }

        public static string EncryptToken(AuthPayload payload)
        {
            var crypt = new AesManaged()
            {
                Key = AuthSecret.Key,
                IV = AuthSecret.IV
            };
            var buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize<AuthPayload>(payload));
            var token = Convert.ToBase64String(
                crypt.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length)
            );
            return token;
        }
    }
}
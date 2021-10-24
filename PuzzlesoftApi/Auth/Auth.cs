using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PuzzlesoftApi.Model;
using Task = System.Threading.Tasks.Task;

namespace PuzzlesoftApi.Auth
{
    public class MyCustomTokenAuthOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScemeName= "MyCustomTokenAuthenticationScheme";
    }

    public class MyCustomTokenAuthHandler : AuthenticationHandler<MyCustomTokenAuthOptions>
    {
        public MyCustomTokenAuthHandler(IOptionsMonitor<MyCustomTokenAuthOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) 
            : base(options, logger, encoder, clock) { }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string username;
            string password;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            
            // get username from db or somewhere else accordining to this token
            try
            {
                using (StreamReader stream = new StreamReader(Request.BodyReader.AsStream()))
                    dict = JsonSerializer.Deserialize<Dictionary<string, string>>(stream.ReadToEnd());
                username = dict["username"];
                password = dict["password"];
                using (var ctx = new dbcompdemoContext())
                {
                    ClientDetail cd = ctx.ClientDetails.FirstOrDefault(u =>
                        u.WorkerUserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                        u.Password == password);
                    if (cd == null)
                        return Task.FromResult(AuthenticateResult.Fail("incorrect credentials"));
                }
            }
            catch (Exception e)
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim(ClaimTypes.Name, username),
                // add other claims/roles as you like
            };
            var id = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(id);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }  
}
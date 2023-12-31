﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
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
        public async Task<PuzzleResponse<CustomToken>> Post([FromBody] UserCredentials cred)
        {
            IsUserInSystemArgs args = new IsUserInSystemArgs {UserName = cred.Username, UserPass = cred.Password};
            var userTable = _context.ExecuteProc<IsUserInSystemTable>("pr_IsUserInSystem", args);
            if (userTable.Response == null)
            {
                return Helper.ReturnError<CustomToken>(userTable.ErrorCode, userTable.ErrorMessage);
            }
            var userRow = userTable.Response.First();
            ClientDetail cd = await _context.ClientDetails.FindAsync(userRow.UserId);
            if (cd == null)
                return null;
            var phoneNumber = cd.GetPhoneNumber();
            if (phoneNumber == null)
                return Helper.ReturnError<CustomToken>(ServerErrors.PhoneNumberDoesNotExists);
            if (!new Regex(@"^(?:\+972|0)5\d\-?\d{7}$").IsMatch(phoneNumber))
                return Helper.ReturnError<CustomToken>(ServerErrors.InvalidPhoneNumber);
            DateTime expiration =
                DateTime.Now.Add(
                    TimeSpan.FromMinutes(_configuration.GetValue<int>("ApiSettings:MinutesToTokenExpiration")));
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
            return new PuzzleResponse<CustomToken>
            {
                Response = new CustomToken
                {
                    Token = token,
                    Expiration = expiration,
                    //QRCodeUrl = setupCode?.QrCodeSetupImageUrl,
                    UserDetails = userRow
                }
            };
        }

        [Authorize]
        [HttpPost("ret_data_to_client_to_shikum")]
        public PuzzleResponse<RetDataToClientToShikum> RetDataToClientToShikum([FromBody]RetDataToClientToShikumArgs args)
        {
            return 
                PuzzlesoftApi.RetDataToClientToShikum.Convert(_context.ExecuteProc
                <RetDataToClientToShikumTable1,
                RetDataToClientToShikumTable2,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable3,
                RetDataToClientToShikumTable4>
                    ("pr_RetDataToClientToShikum", args, User));
        }

        [Authorize]
        [HttpPost("add_rep_to_follow")]
        public PuzzleResponse<string> AddRepToFollow([FromBody]AddRepToFollowArgs args)
        {
            return _context.ExecuteProc("pr_AddRepToFollow", args, User);
        }
        
        [Authorize]
        [HttpDelete("del_rep_to_follow")]
        public PuzzleResponse<string> DelRepToFollow([FromBody]DelRepToFollowArgs args)
        {
            return _context.ExecuteProc("pr_DelRepToFollow", args, User);
        }

        [HttpGet("resend")]
        public async Task Resend([FromHeader(Name="Authorization")]string token)
        {
            var payload = AuthSecret.DecryptToken(token);
            var cd = await _context.ClientDetails.FindAsync(payload.UserId);
            var code = _totl.CreateTotl(cd.Id.ToString());

            var s = await SmsService.SendSms(cd.GetPhoneNumber(),
                string.Format(_configuration.GetValue<string>("ApiSettings:SmsMessage"), code));
            _logger.LogDebug(s);
        }
        [HttpGet("get_phone")]
        public async Task<string> getPhone([FromHeader(Name="Authorization")]string token)
        {
            var payload = AuthSecret.DecryptToken(token);
            var cd = await _context.ClientDetails.FindAsync(payload.UserId);

            var phoneNumber = cd.GetPhoneNumber();
            return phoneNumber;
        }

        [Authorize]
        [HttpPost("medical_query")]
        public PuzzleResponse<List<MedicalTask>> MedicalQuery([FromBody]MedicalQueryParams args)
        {
            return _context.ExecuteProc<MedicalTask>("api.pr_MedicalTask_Query", args, User);
        }
        [Authorize]
        [HttpGet("medical_catalog")]
        public PuzzleResponse<List<MedicalCatalog>> MedicalCatalog([FromQuery]MedicalCatalogParams args)
        {
            return _context.ExecuteProc<MedicalCatalog>("api.pr_MedicalTask_Catalog", args, User);
        }
        
        [Authorize]
        [HttpPost("medical_create")]
        public IActionResult MedicalCreate([FromBody]MedicalCreateParams args)
        {
            _context.ExecuteProc("api.pr_MedicalTask_CreateUsingCatalogId", args, User);
            return NoContent();
        }
    }

}

using System;
using System.Collections.Generic;
using ElmahCore;

namespace PuzzlesoftApi
{
   
    public static class Messages
    {
        public const string _TokenExpired = "token expired";
        public const string _MFANotValid = "authentication process was not completed by the user";
        public const string PhoneDoesNotExists =
            "לא נמצא מספר טלפון נייד לשליחת קוד התחברות חד פעמי. אנא פנה למערכות מידע של הארגון";

        public const string MfaInvalidCode = "קוד האימות שגוי/פג תוקף קוד האימות";
        public const string InvalidPhoneNumber = "מספר הטלפון הקיים במערכות המידע אינו תקין. אנא פנה למערכות מידע של הארגון";
    }

    public enum ServerErrors
    {
        InvalidMfaCode = 300,
        InvalidPhoneNumber,
        PhoneNumberDoesNotExists
    }
    public static class Errors
    {
        public static Dictionary<ServerErrors, string> errors = new Dictionary<ServerErrors, string>()
        {
            {ServerErrors.InvalidMfaCode, Messages.MfaInvalidCode},
            {ServerErrors.InvalidPhoneNumber, Messages.InvalidPhoneNumber},
            {ServerErrors.PhoneNumberDoesNotExists, Messages.PhoneDoesNotExists}
        };
    }

    public class ElmahFilter : IErrorFilter
    {
        public void OnErrorModuleFiltering(object sender, ExceptionFilterEventArgs args)
        {
            if (args.Exception is PuzzlesoftGlobalError)
                args.Dismiss();
        }
    }
}
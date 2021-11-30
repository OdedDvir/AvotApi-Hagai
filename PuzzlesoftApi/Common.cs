
using System;
using System.Collections.Generic;
using ElmahCore;
using Newtonsoft.Json;

namespace PuzzlesoftApi
{
   
    public static class Messages
    {
        public const string _TokenExpired = "token expired";
        public const string _MFANotValid = "authentication process was not completed by the user";
        public const string _UserLoggedOut = "user has logged out";
        public const string Unauthorized = "הגישה נדחתה, ההתחברות לא הושלמה, או שפג תוקפה";
        public const string PhoneDoesNotExists =
            "לא נמצא מספר טלפון נייד לשליחת קוד התחברות חד פעמי. אנא פנה למערכות מידע של הארגון";

        public const string MfaInvalidCode = "קוד האימות שגוי/פג תוקף קוד האימות";
        public const string InvalidPhoneNumber = "מספר הטלפון הקיים במערכות המידע אינו תקין. אנא פנה למערכות מידע של הארגון";
    }

    public enum ServerErrors
    {
        InvalidMfaCode = 300,
        InvalidPhoneNumber,
        PhoneNumberDoesNotExists,
        AuthenticationFailed,
        UnhandledException
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
    public class IsUserInSystemArgs
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
    }
    public class RetDataToClientToShikumArgs
    {
        public string Idcard { get; set; }
        [UserId]
        private int UserId { get; set; }
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
        private int UserId { get; set; }
    }

    public class DelRepToFollowArgs
    {
        public int ID { get; set; }
        [UserId]
        private int UserId { get; set; }
    }

    public class PuzzleResponse<T>
    {
        [JsonProperty("response")] public T Response { get; set; }
        [JsonProperty("error_code")] public string ErrorCode { get; set; } = "100";
        [JsonProperty("error_message")] public string ErrorMessage { get; set; } = string.Empty;
    }

    public class PuzzleDataset<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> 
        where T0: new()
        where T1: new()
        where T2: new()
        where T3: new() 
        where T4: new() 
        where T5: new() 
        where T6: new() 
        where T7: new() 
        where T8: new() 
        where T9: new() 
        where T10: new()
    {
        public List<T0> Table;
        public List<T1> Table1;
        public List<T2> Table2;
        public List<T3> Table3;
        public List<T4> Table4;
        public List<T5> Table5;
        public List<T6> Table6;
        public List<T7> Table7;
        public List<T8> Table8;
        public List<T9> Table9;
        public List<T10> Table10;
    }

    public class IsUserInSystemTable
    {
        public int IsSucess { get; set; }
        public int UserId { get; set; }
        public int MGroupId { get; set; }
        public string MGroupItem { get; set; }
        public int FollowId { get; set; }
        public string UserFName { get; set; }
    }

    public class RetDataToClientToShikumTable1
    {
        public int ClientId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string IDCard { get; set; }
        public string Gender { get; set; }
        public string Age2 { get; set; }
        public string Kupa { get; set; }
        public string DateNeedEnter { get; set; }
        public string DtFree_DtCngStt { get; set; }
    }

    public class RetDataToClientToShikumTable2
    {
        public string Avhanakod { get; set; }
        public string Status { get; set; }
        public string DateS { get; set; }
        public string DateE { get; set; }
        public string tStamp { get; set; }
        public string UserCreate { get; set; }
        public string AvahanaFull { get; set; }
    }

    public class RetDataToClientToShikumTable3
    {
        public string Cap1 { get; set; }
        public string Id { get; set; }
        public int TypeForm { get; set; }
        public string DoctorName { get; set; }
        public string val1 { get; set; }
        public string Val2 { get; set; }
        public string UserCreate { get; set; }
        public string Subject1 { get; set; }
        public string DateNTime { get; set; }
    }

    public class RetDataToClientToShikumTable4
    {
        public bool bDel { get; set; }
        public int FollowID { get; set; }
        public string FollowKey { get; set; }
        public int ID { get; set; }
        public string Item { get; set; }
        public int Kod1 { get; set; }
        public int OrderID { get; set; }
        public int Val1 { get; set; }
    }

    public class RetDataToClientToShikum
    {
        public List<RetDataToClientToShikumTable1> Table { get; set; }
        public List<RetDataToClientToShikumTable2> Table1 { get; set; }
        public List<RetDataToClientToShikumTable3> Table2 { get; set; }
        public List<RetDataToClientToShikumTable3> Table3 { get; set; }
        public List<RetDataToClientToShikumTable3> Table4 { get; set; }
        public List<RetDataToClientToShikumTable3> Table5 { get; set; }
        public List<RetDataToClientToShikumTable3> Table6 { get; set; }
        public List<RetDataToClientToShikumTable3> Table7 { get; set; }
        public List<RetDataToClientToShikumTable3> Table8 { get; set; }
        public List<RetDataToClientToShikumTable3> Table9 { get; set; }
        public List<RetDataToClientToShikumTable4> Table10 { get; set; }

        public static PuzzleResponse<RetDataToClientToShikum> Convert(PuzzleResponse<PuzzleDataset<
            RetDataToClientToShikumTable1,
            RetDataToClientToShikumTable2,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable3,
            RetDataToClientToShikumTable4
        >> src)
        {
            return new PuzzleResponse<RetDataToClientToShikum>()
            {
                ErrorMessage = src.ErrorMessage,
                ErrorCode = src.ErrorCode,
                Response = new RetDataToClientToShikum()
                {
                    Table = src.Response.Table,
                    Table1 = src.Response.Table1,
                    Table2 = src.Response.Table2,
                    Table3 = src.Response.Table3,
                    Table4 = src.Response.Table4,
                    Table5 = src.Response.Table5,
                    Table6 = src.Response.Table6,
                    Table7 = src.Response.Table7,
                    Table8 = src.Response.Table8,
                    Table9 = src.Response.Table9,
                    Table10 = src.Response.Table10,
                }
            };
        }
    }
}
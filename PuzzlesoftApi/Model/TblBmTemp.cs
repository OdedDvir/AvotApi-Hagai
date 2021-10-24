using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBmTemp
    {
        public int Id { get; set; }
        public string ReqId { get; set; }
        public string Bmid { get; set; }
        public string Idcard { get; set; }
        public int? ClientId { get; set; }
        public string Val1 { get; set; }
        public string Memo1 { get; set; }
        public string Min1 { get; set; }
        public string Max1 { get; set; }
        public string Bmname { get; set; }
        public string Ym { get; set; }
        public bool? BSpec { get; set; }
        public string LogMsg { get; set; }
        public bool? LogErr { get; set; }
        public DateTime? LastRead { get; set; }
    }
}

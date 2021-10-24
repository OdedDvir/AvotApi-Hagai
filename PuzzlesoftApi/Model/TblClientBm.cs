using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientBm
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public DateTime? Date1 { get; set; }
        public string Val1 { get; set; }
        public int? ClientId { get; set; }
        public string UserCreate { get; set; }
        public bool? BCorrect { get; set; }
        public double? DefMin { get; set; }
        public double? DefMax { get; set; }
        public string DefYm { get; set; }
        public string Time1 { get; set; }
        public string UniqKey { get; set; }
        public string Memo1 { get; set; }
        public bool? BDel { get; set; }
        public bool? BNoCorrect { get; set; }
        public DateTime? TStamp { get; set; }
        public int? TransId { get; set; }
        public int? UserCreateid { get; set; }
        public string UId { get; set; }
        public string ReqId { get; set; }
        public string InviteDate { get; set; }
        public bool BCulture { get; set; }
        public string Material { get; set; }
        public string Test { get; set; }
        public string FileUrl { get; set; }
        public string FileSrc { get; set; }
        public bool? BIsolation { get; set; }
        public string FName1 { get; set; }
        public string FSubject { get; set; }
        public bool BFree { get; set; }
    }
}

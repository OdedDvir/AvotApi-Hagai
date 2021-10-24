using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblParamFollow
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string Key1 { get; set; }
        public string Val1 { get; set; }
        public string Memo1 { get; set; }
        public int? BDel { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public bool? BExp { get; set; }
        public string TempName { get; set; }
        public int? Clientid { get; set; }
        public int? NConv { get; set; }
        public int? Rowid { get; set; }
        public int FormId { get; set; }
        public string ReportBy { get; set; }
        public bool Cannt { get; set; }
    }
}

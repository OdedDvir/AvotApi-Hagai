using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDiagnosisFunction
    {
        public int Id { get; set; }
        public DateTime? DateDiagnosis { get; set; }
        public int? LvelDelay { get; set; }
        public string LevelFunction { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? UserIdcreate { get; set; }
        public int? ClientId { get; set; }
        public bool? BDel { get; set; }
        public DateTime? DateCommittee { get; set; }
        public string Memo { get; set; }
    }
}

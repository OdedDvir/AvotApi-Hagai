using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientNursingPlan
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public int ClientId { get; set; }
        public int SiudThemeId { get; set; }
        public string ProblemId { get; set; }
        public string TipulPlan { get; set; }
        public string Results { get; set; }
        public DateTime? DateEnd { get; set; }
        public string WorkerGroup { get; set; }
        public int? YeshivaId { get; set; }
        public string ProblemDetails { get; set; }
        public string UserDone { get; set; }
        public string KindKey { get; set; }
        public string Symptoms { get; set; }
        public string Targets { get; set; }
        public bool? Archive { get; set; }
        public bool? BDel { get; set; }
        public string Problem { get; set; }
        public DateTime? TStamp { get; set; }
        public int? ImmedId { get; set; }
        public int? UserCreateId { get; set; }
    }
}

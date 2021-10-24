using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblExpertsAdvise
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string ExpertName { get; set; }
        public string ExpertJob { get; set; }
        public DateTime? Date1 { get; set; }
        public string AdviseDesc { get; set; }
        public string Tasks { get; set; }
        public bool? BDel { get; set; }
        public string Hour1 { get; set; }
        public string Hour2 { get; set; }
        public bool? Accompany { get; set; }
        public string Target { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateInvite { get; set; }
        public bool ExternalI { get; set; }
        public bool BExport { get; set; }
        public bool BExportDone { get; set; }
        public DateTime? DateExport { get; set; }
        public bool BExportWeb { get; set; }
        public bool BExportWebDone { get; set; }
        public DateTime? DateWebExport { get; set; }
        public bool BExportRetData { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTelemarketingAction
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string ActionKind { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
        public int? WorkerId { get; set; }
        public string B2bUserName { get; set; }
        public bool? BDel { get; set; }
        public string StatusS { get; set; }
        public DateTime? TsTemp { get; set; }
    }
}

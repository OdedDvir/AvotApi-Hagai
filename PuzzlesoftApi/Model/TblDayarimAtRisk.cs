using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDayarimAtRisk
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string RiskReason { get; set; }
        public string Details { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? BDel { get; set; }
        public string DelReason { get; set; }
        public DateTime? DateE { get; set; }
    }
}

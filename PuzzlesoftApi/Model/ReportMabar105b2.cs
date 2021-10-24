using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ReportMabar105b2
    {
        public int Id { get; set; }
        public int? ReportId { get; set; }
        public string DayarName { get; set; }
        public DateTime? DateEnter { get; set; }
        public DateTime? DateExit { get; set; }
        public short? NumDays { get; set; }
        public string ExitTarget { get; set; }
    }
}

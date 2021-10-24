using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMonthlyForm
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public short? Year { get; set; }
        public short? Month { get; set; }
        public bool? Locked { get; set; }
        public string Details { get; set; }
        public short? MahlakaId { get; set; }
        public int? TypFormId { get; set; }
        public int? UserIdlocked { get; set; }
        public string FieldA { get; set; }
        public string HtmlSource { get; set; }
        public DateTime? DateLocked { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? UserIdcreate { get; set; }
        public short? DayarimCount { get; set; }
        public byte? LocationId { get; set; }
        public int? HeshbonitId { get; set; }
        public int? SponserId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMabarReport
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public short? Year { get; set; }
        public short? Month { get; set; }
        public bool? Locked { get; set; }
        public string Details { get; set; }
        public short? MahlakaId { get; set; }
        public int? TypFormId { get; set; }
        public string UserLocked { get; set; }
        public string FieldA { get; set; }
        public double? DayPrice { get; set; }
    }
}

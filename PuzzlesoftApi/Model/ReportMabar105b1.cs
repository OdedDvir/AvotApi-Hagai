using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ReportMabar105b1
    {
        public int Id { get; set; }
        public int? ReportId { get; set; }
        public string Siudit { get; set; }
        public short? Year { get; set; }
        public short? Month { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public bool? Locked { get; set; }
    }
}

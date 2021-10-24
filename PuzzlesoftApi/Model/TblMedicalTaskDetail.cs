using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedicalTaskDetail
    {
        public int Id { get; set; }
        public string TaskTheme { get; set; }
        public string Description { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public int? WorkerId { get; set; }
        public int? DayarId { get; set; }
        public string Status { get; set; }
        public string Summery { get; set; }
    }
}

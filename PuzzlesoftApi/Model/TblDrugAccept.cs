using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugAccept
    {
        public int Id { get; set; }
        public string DayarName { get; set; }
        public DateTime? Date1 { get; set; }
        public int? DDayarId { get; set; }
        public int? MirshamId { get; set; }
    }
}

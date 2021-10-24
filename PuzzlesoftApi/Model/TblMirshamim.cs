using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMirshamim
    {
        public int Id { get; set; }
        public string DayarName { get; set; }
        public DateTime? Date1 { get; set; }
        public string Kupa { get; set; }
        public string Idcard { get; set; }
        public int? ClientId { get; set; }
        public string MirshamCap { get; set; }
        public DateTime? Tstamp { get; set; }
        public bool BNarkotika { get; set; }
        public string ReasonDetail { get; set; }
        public int UserIdCreate { get; set; }
    }
}

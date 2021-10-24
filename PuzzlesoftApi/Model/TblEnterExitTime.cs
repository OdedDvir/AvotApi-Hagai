using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblEnterExitTime
    {
        public int Id { get; set; }
        public string ClientKod { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? EnterTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public int? ThemeId { get; set; }
        public string Comment { get; set; }
    }
}

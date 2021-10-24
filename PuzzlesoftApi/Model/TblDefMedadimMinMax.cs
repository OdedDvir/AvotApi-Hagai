using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefMedadimMinMax
    {
        public int Id { get; set; }
        public string MadadName { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public int? Min1 { get; set; }
        public int? Max1 { get; set; }
        public int? MinColor { get; set; }
        public int? MaxColor { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMishkalim
    {
        public int Id { get; set; }
        public int? High { get; set; }
        public double? MenMin { get; set; }
        public double? MenMax { get; set; }
        public double? WomenMin { get; set; }
        public double? WomenMax { get; set; }
    }
}

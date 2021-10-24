using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Csvtest2
    {
        public int Id { get; set; }
        public DateTime KabalaDate { get; set; }
        public int? MisSnif { get; set; }
        public string NameSnif { get; set; }
        public string MisHeshbon { get; set; }
        public string NameBank { get; set; }
        public int? MisCheck { get; set; }
        public int SumHesh { get; set; }
        public DateTime? TashlumDate { get; set; }
    }
}

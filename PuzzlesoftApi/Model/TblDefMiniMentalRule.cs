using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefMiniMentalRule
    {
        public int Id { get; set; }
        public int Val { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public int EducationMin { get; set; }
        public int EducationMax { get; set; }
    }
}

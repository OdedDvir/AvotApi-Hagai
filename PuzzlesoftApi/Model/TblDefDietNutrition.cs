using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefDietNutrition
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public bool Bdel { get; set; }
        public DateTime Tstamp { get; set; }
    }
}

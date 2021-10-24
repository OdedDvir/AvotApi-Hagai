using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefDietDrugNotGivenReson
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Ordid { get; set; }
        public int Mainid { get; set; }
        public bool Bdel { get; set; }
    }
}

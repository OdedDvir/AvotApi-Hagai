using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblListPriceRoom
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? Archive { get; set; }
        public DateTime? Date2 { get; set; }
        public float? Madad { get; set; }
        public string Name1 { get; set; }
        public float FactorAhzaka { get; set; }
        public DateTime? MadadDate { get; set; }
        public float FactorEnterPrice { get; set; }
        public float MadadAhzaka { get; set; }
        public float MadadAhzakaBasic { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHeshDocItem
    {
        public int Id { get; set; }
        public int? DocId { get; set; }
        public int? ParitId { get; set; }
        public float? Quantity { get; set; }
        public double? Price { get; set; }
        public float? PerDiscount { get; set; }
        public double? TotalPrice { get; set; }
        public string ParitName { get; set; }
        public string ParitKod { get; set; }
        public bool? Maham { get; set; }
        public string Unit { get; set; }
        public int? UnitId { get; set; }
        public string Coin { get; set; }
        public decimal? Rate { get; set; }
        public string Comments { get; set; }
        public short? MiunId { get; set; }
        public string MelayKod { get; set; }
        public string ParitKod2 { get; set; }
        public float? QuantityCount { get; set; }
        public string KodparitOld { get; set; }
        public string ParitkodOld { get; set; }

        public virtual TblHeshDocument Doc { get; set; }
    }
}

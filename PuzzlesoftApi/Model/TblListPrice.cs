using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblListPrice
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? BSale { get; set; }
        public short? BasicList { get; set; }
        public float? Multiple { get; set; }
        public short? Round { get; set; }
        public bool? Locked { get; set; }
        public int? SapakId { get; set; }
        public DateTime? Date2 { get; set; }
        public string Key1 { get; set; }
        public int? NKind { get; set; }
        public string Caption1 { get; set; }
        public short? LocationId { get; set; }
        public bool? Archive { get; set; }
        public bool? BDel { get; set; }
        public int? SapakDiscount { get; set; }
        public decimal Madad1 { get; set; }
    }
}

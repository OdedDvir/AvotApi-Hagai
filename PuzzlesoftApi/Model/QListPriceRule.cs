using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QListPriceRule
    {
        public int Id { get; set; }
        public string RuleName { get; set; }
        public short MainKind { get; set; }
        public string ParitKod { get; set; }
        public DateTime DateS { get; set; }
        public DateTime DateE { get; set; }
        public decimal AddSum { get; set; }
        public short AddPercent { get; set; }
        public int MinUnits { get; set; }
        public short LocationId { get; set; }
        public string ClientKind { get; set; }
        public string ParitName { get; set; }
        public bool BDel { get; set; }
    }
}

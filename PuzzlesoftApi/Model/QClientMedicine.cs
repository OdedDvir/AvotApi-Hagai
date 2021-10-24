using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientMedicine
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string TradeKind { get; set; }
        public string TradeName { get; set; }
        public short? Minun { get; set; }
        public short? DaysNum { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

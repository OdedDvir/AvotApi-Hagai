using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblSynelCharge
    {
        public int ClientId { get; set; }
        public string ChargeKod { get; set; }
        public string ChargeName { get; set; }
        public DateTime? Date1 { get; set; }
        public short BDay { get; set; }
        public decimal? UnitPrice { get; set; }
        public short Quantity { get; set; }
        public int SynelKind { get; set; }
        public string Idcard { get; set; }
        public int? MiunId { get; set; }
    }
}

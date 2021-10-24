using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QChargeShehium
    {
        public string NameView { get; set; }
        public string ChargeShehiaType { get; set; }
        public int Id { get; set; }
        public string ChargeKod { get; set; }
        public double? Price1 { get; set; }
        public int? ClientId { get; set; }
        public string ChargeText { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? LastCharge { get; set; }
        public int? ChargeMiun { get; set; }
        public string RoomName { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public double? PriceBasic { get; set; }
        public string ChargeCoin { get; set; }
        public decimal? ChargeMadadBasis { get; set; }
        public short? UpdateToMadadBasis { get; set; }
        public decimal? ChargeLastMadad { get; set; }
        public string Memo1 { get; set; }
        public double PriceBasicDolar { get; set; }
        public string LastChargeMonth { get; set; }
        public string DateS { get; set; }
        public string DateE { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblCharge
    {
        public int Id { get; set; }
        public DateTime? ChargeDate { get; set; }
        public int? KindId { get; set; }
        public string Unit { get; set; }
        public float? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? HatsmadaId { get; set; }
        public string LinkedDoc { get; set; }
        public string ChargeName { get; set; }
        public string Description { get; set; }
        public decimal? TotalSum { get; set; }
        public bool? Maham { get; set; }
        public bool? Active { get; set; }
        public int? ClientId { get; set; }
        public string PayDetails { get; set; }
        public bool? BCharge { get; set; }
        public string ChargeKod { get; set; }
        public int? CoinId { get; set; }
        public decimal? Rate { get; set; }
        public bool? NotInHesh { get; set; }
        public int? ParitId { get; set; }
        public int? ChargeMiun { get; set; }
        public bool? BMelayKodDrug { get; set; }
        public string MelayKod { get; set; }
        public string ChargeKod2 { get; set; }
        public string MonimTime { get; set; }
        public string MonimNum { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public int? RelateClientId { get; set; }
        public int? SponserId { get; set; }
        public string ChargeKodOld { get; set; }
        public string MelayKodOld { get; set; }
        public string ChargeKod2Old { get; set; }
        public DateTime? ChargeMonth { get; set; }
        public int HeshId { get; set; }
    }
}

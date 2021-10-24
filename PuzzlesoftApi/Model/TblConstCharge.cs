using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConstCharge
    {
        public int Id { get; set; }
        public int? ParitId { get; set; }
        public string ParitName { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? ClientId { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? Active { get; set; }
        public string ParitKod { get; set; }
        public decimal? Price1 { get; set; }
        public string LastCharge { get; set; }
        public string Memo1 { get; set; }
        public int? SponserId { get; set; }
        public int? UserId { get; set; }
        public DateTime? LastCharge2 { get; set; }
        public int? TnouaId { get; set; }
        public bool? BChargeByTofes17 { get; set; }
        public int? ChargeKind { get; set; }
        public bool? BClient { get; set; }
        public decimal? PriceBasic { get; set; }
        public decimal? ChargeMadadBasis { get; set; }
        public decimal? UpdateToMadadBasis { get; set; }
        public decimal? ChargeLastMadad { get; set; }
        public bool? BChargeDayByStay { get; set; }
        public bool? BChargeDayByStayN17 { get; set; }
        public int? NChargeKind { get; set; }
        public bool? BSpec { get; set; }
        public string ParitKodOld { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAmbulance
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Dt1 { get; set; }
        public string Time1 { get; set; }
        public string Target { get; set; }
        public string Place { get; set; }
        public string Reason { get; set; }
        public decimal? Price { get; set; }
        public short? BUrgent { get; set; }
        public bool? BExit { get; set; }
        public int? KindId { get; set; }
        public int? ChargeId { get; set; }
        public float PriceLivuy { get; set; }
        public int ChargeLivuyId { get; set; }
        public int SponserId { get; set; }
        public bool? BAuto { get; set; }
        public int? RelatedHfnayaId { get; set; }
        public bool? BFamilyLivuy { get; set; }
        public bool? BPay { get; set; }
        public string PayBy { get; set; }
        public string NumBill { get; set; }
        public int? IshpuzId { get; set; }
        public bool? BStatus { get; set; }
        public string Memo { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
    }
}

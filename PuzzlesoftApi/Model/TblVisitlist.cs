using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblVisitlist
    {
        public int Id { get; set; }
        public int? YomanId { get; set; }
        public int? SnifId { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? BDel { get; set; }
        public int? NTorType { get; set; }
        public string Kod1 { get; set; }
        public int? PriceId { get; set; }
        public int? GroupId { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TimeArrived { get; set; }
        public bool? BDone { get; set; }
        public int? NTorRanhe { get; set; }
        public int? NTorRange { get; set; }
        public int? ResId { get; set; }
        public int? PlaceId { get; set; }
        public int? Clientid { get; set; }
        public bool? NotArrived { get; set; }
        public int? Tofes17Id { get; set; }
        public bool? BArrived { get; set; }
        public bool BNeedPay { get; set; }
        public bool BLocked { get; set; }
    }
}

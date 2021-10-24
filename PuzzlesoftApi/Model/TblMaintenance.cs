using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMaintenance
    {
        public int Id { get; set; }
        public short? NStatus { get; set; }
        public DateTime? DateR { get; set; }
        public DateTime? TimeR { get; set; }
        public int? UserRequest { get; set; }
        public string RequestComments { get; set; }
        public string RequestItemsNeed { get; set; }
        public int? RequestSendTo { get; set; }
        public DateTime? DateA { get; set; }
        public DateTime? TimeA { get; set; }
        public int? UserAllowed { get; set; }
        public string AllowedComments { get; set; }
        public int? AllowedSendTo { get; set; }
        public DateTime? DateD { get; set; }
        public DateTime? TimeD { get; set; }
        public int? UserSetDone { get; set; }
        public string DoneComments { get; set; }
        public string ItemsUsed { get; set; }
        public DateTime? DateResponsibility { get; set; }
        public string DoneLinkFile { get; set; }
        public bool? BHaveResponsibility { get; set; }
        public int? AgafId { get; set; }
        public int? RoomId { get; set; }
        public int? ItemId { get; set; }
        public int? ClientToCharge { get; set; }
        public short? LocationId { get; set; }
        public string ChargeKod { get; set; }
        public int? UserOrderId { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? TimeS { get; set; }
        public int? TakalaKind { get; set; }
        public string TakalaDescription { get; set; }
        public short? NLevel { get; set; }
        public short? NWorkerKind { get; set; }
        public int? WorkerDoneId { get; set; }
        public bool? BClosed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? ClosedTime { get; set; }
        public string DayarimNames { get; set; }
        public short? JumpDays { get; set; }
        public int? RequestKindId { get; set; }
        public string DayarPhone { get; set; }
        public DateTime? DateReccurenceEnd { get; set; }
        public string InventarKod { get; set; }
        public int? InventarBarcode { get; set; }
        public bool? BDel { get; set; }
        public string Yozem { get; set; }
        public double? RequestPrice { get; set; }
        public string PriceComments { get; set; }
        public int UserIdclosed { get; set; }
        public DateTime? DateP { get; set; }
        public DateTime? TimeP { get; set; }
        public bool? BSentByMail { get; set; }
    }
}

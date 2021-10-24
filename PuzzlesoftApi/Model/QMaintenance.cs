using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QMaintenance
    {
        public int Id { get; set; }
        public short? NStatus { get; set; }
        public DateTime? DateR { get; set; }
        public DateTime? TimeR { get; set; }
        public DateTime? DateD { get; set; }
        public DateTime? DateP { get; set; }
        public DateTime? TimeP { get; set; }
        public DateTime? TimeD { get; set; }
        public string DoneComments { get; set; }
        public int? RoomId { get; set; }
        public short? LocationId { get; set; }
        public int? TakalaKind { get; set; }
        public string DayarPhone { get; set; }
        public string TakalaDescription { get; set; }
        public short? NLevel { get; set; }
        public bool? BClosed { get; set; }
        public bool? BSentByMail { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? ClosedTime { get; set; }
        public string DayarimNames { get; set; }
        public string InnerNum { get; set; }
        public string Subject1 { get; set; }
        public string Roomname { get; set; }
        public int? WorkerDoneId { get; set; }
        public short? NWorkerKind { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? TimeS { get; set; }
        public int? AgafId { get; set; }
        public int? UserRequest { get; set; }
        public string UserRequestName { get; set; }
        public string RequestKind { get; set; }
        public int? RequestKindId { get; set; }
        public string Yozem { get; set; }
        public int? TakalaKindMiun { get; set; }
        public string TakalaKindMiunName { get; set; }
        public string AgafName { get; set; }
        public short? JumpDays { get; set; }
        public string WorkerName { get; set; }
        public string Place1 { get; set; }
        public string TaskStatus { get; set; }
        public string Level1 { get; set; }
        public string PlaceWithDayar { get; set; }
        public string PlaceWithDayarGanim { get; set; }
        public string InventarKod { get; set; }
        public int? InventarBarcode { get; set; }
        public bool? BDel { get; set; }
        public string ParitName { get; set; }
    }
}

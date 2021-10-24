using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTyingClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? DateEnd { get; set; }
        public string TyingKindId { get; set; }
        public string TyingEvarId { get; set; }
        public string TyingEvarName { get; set; }
        public string TyingLimitHow { get; set; }
        public string TyingReasonId { get; set; }
        public string TyingReasonName { get; set; }
        public string TyingMemo { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? Bdel { get; set; }
        public string ParticipantsName { get; set; }
        public string ParticipantsId { get; set; }
        public string Result { get; set; }
        public int? FrequencyId { get; set; }
        public string AgreeFamily { get; set; }
        public bool Status { get; set; }
        public int? TipulId { get; set; }
        public string StatusReason { get; set; }
        public string TyingKindName { get; set; }
        public bool DecidedInStaffMeeting { get; set; }
        public string CommitteeRep { get; set; }
        public string Time1 { get; set; }
        public DateTime? DateRenew { get; set; }
        public string TimeRenew { get; set; }
        public bool BArchive { get; set; }
        public bool BPsichater { get; set; }
        public string Time2 { get; set; }
        public int UserIdStop { get; set; }
    }
}

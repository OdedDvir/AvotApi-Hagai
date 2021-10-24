using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPhizioMonthActivity
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public DateTime? Month1 { get; set; }
        public int? ActivityId { get; set; }
        public string SuccessActivityId { get; set; }
        public string SuccessActivityItem { get; set; }
        public string SuccessActivityMemo { get; set; }
        public string FailedActivityId { get; set; }
        public string FailedActivityItem { get; set; }
        public string FailedActivityMemo { get; set; }
        public int? LevelParticipation { get; set; }
        public string KindInstructionsId { get; set; }
        public string KindInstructionsItem { get; set; }
        public int? SocialInteractionId { get; set; }
        public string SocialInteractionItem { get; set; }
        public string ReasonChangeId { get; set; }
        public string ReasonChangeItem { get; set; }
        public int? Frequency { get; set; }
        public string RightUpperLimbId { get; set; }
        public string RightUpperLimbItem { get; set; }
        public string LeftUpperLimbId { get; set; }
        public string LeftUpperLimbItem { get; set; }
        public string Memo { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? BDel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QPhizioMonthActivity
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public bool? BDel { get; set; }
        public string Month1 { get; set; }
        public DateTime? Month2 { get; set; }
        public string Activity { get; set; }
        public int? ActivityId { get; set; }
        public string ActivitiesDetails { get; set; }
        public int? LevelParticipation { get; set; }
        public string KindInstructions { get; set; }
        public string SocialInteraction { get; set; }
        public string ReasonChange { get; set; }
        public int? Frequency { get; set; }
        public string RightUpperLimb { get; set; }
        public string LeftUpperLimb { get; set; }
        public string UserCreate { get; set; }
        public string Memo { get; set; }
    }
}

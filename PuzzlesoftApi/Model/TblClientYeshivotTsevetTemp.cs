using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientYeshivotTsevetTemp
    {
        public DateTime? DateCreate { get; set; }
        public string DayarName { get; set; }
        public int Id { get; set; }
        public int YeshivaId { get; set; }
        public string Summery { get; set; }
        public int? ClientId { get; set; }
        public string Target { get; set; }
        public DateTime? NextYeshivaDate { get; set; }
        public bool? BDel { get; set; }
        public string LastYeshivaRef { get; set; }
        public DateTime? TStamp { get; set; }
        public int? UserCreateId { get; set; }
        public bool? BLocked { get; set; }
        public int? UserIdLock { get; set; }
        public DateTime? DateLocked { get; set; }
        public string AddParticipates { get; set; }
        public int? DateInfoId { get; set; }
        public DateTime? DateInfo { get; set; }
        public string RecommendedClinics { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientYeshivotTsevet
    {
        public DateTime? DateCreate { get; set; }
        public string DayarName { get; set; }
        public int Id { get; set; }
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
        public DateTime? Date1 { get; set; }
        public string NameView { get; set; }
        public short? LocationId { get; set; }
        public short? MainKind { get; set; }
        public bool? Archive { get; set; }
        public short? MahlakaId { get; set; }
        public string DateNeedEnter { get; set; }
    }
}

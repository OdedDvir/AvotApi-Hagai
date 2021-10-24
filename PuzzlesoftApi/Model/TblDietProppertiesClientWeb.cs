using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietProppertiesClientWeb
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string TeethIdList { get; set; }
        public string TeethComment { get; set; }
        public string TeethList { get; set; }
        public string Swallowing { get; set; }
        public int? HowFeedId { get; set; }
        public string HowFeedComment { get; set; }
        public int? HowFeedPoid { get; set; }
        public string HowFeedPocomment { get; set; }
        public bool PoChkIrrelevant { get; set; }
        public double? CalculatesMpo1 { get; set; }
        public double? CalculatesMpo2 { get; set; }
        public double? CalculatesMpo3 { get; set; }
        public double? CalculatesMpo11 { get; set; }
        public double? CalculatesMpo22 { get; set; }
        public double? CalculatesMpo33 { get; set; }
        public int FormId { get; set; }
        public bool BDel { get; set; }
        public bool BArchive { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public DateTime Date1 { get; set; }
    }
}

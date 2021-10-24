using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFeedTubeWeb
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FormId { get; set; }
        public int KabalaId { get; set; }
        public DateTime DateS { get; set; }
        public int? VolFood { get; set; }
        public int? VolLiq { get; set; }
        public int? VolWater { get; set; }
        public int? VolWaterSum { get; set; }
        public double? CaloriesSum { get; set; }
        public double? CaloriesKg { get; set; }
        public double? ProteinSum { get; set; }
        public double? ProteinKg { get; set; }
        public double? LiquidsSum { get; set; }
        public double? LiquidsKg { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public bool BDel { get; set; }
        public bool BArchive { get; set; }
    }
}

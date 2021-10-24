using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietVlientPo
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int GroupId { get; set; }
        public int FormId { get; set; }
        public string MenuKindListId { get; set; }
        public string MenuKindList { get; set; }
        public int? FabricMenuS { get; set; }
        public int? FabricMenuL { get; set; }
        public DateTime DateS { get; set; }
        public DateTime? DateE { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
    }
}

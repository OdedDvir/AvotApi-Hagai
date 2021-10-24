using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietClientPoComp1
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int GroupId { get; set; }
        public int FormId { get; set; }
        public int KabalaId { get; set; }
        public int RecStatus { get; set; }
        public string MenuKindListId { get; set; }
        public string MenuKindList { get; set; }
        public string FabricMenuSid { get; set; }
        public string FabricMenuLid { get; set; }
        public string FabricMenuS { get; set; }
        public string FabricMenuL { get; set; }
        public DateTime DateS { get; set; }
        public DateTime? DateE { get; set; }
        public string Comment { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public int? StopUserId { get; set; }
        public string Stopresone { get; set; }
    }
}

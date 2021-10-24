using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietStopTempClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime DateS { get; set; }
        public DateTime DateE { get; set; }
        public int RowId { get; set; }
        public int GroupId { get; set; }
        public int Type { get; set; }
        public int FormId { get; set; }
        public string Reason { get; set; }
        public bool BDel { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public int? UserIdstop { get; set; }
        public DateTime? TsStop { get; set; }
    }
}

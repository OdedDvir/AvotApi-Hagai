using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblLogTable
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public DateTime? TStamp { get; set; }
        public string Table1 { get; set; }
        public string Action1 { get; set; }
        public int? RecId { get; set; }
        public string RecDetails { get; set; }
        public int? MahlakaId { get; set; }
        public int? ClientId { get; set; }
        public int FormId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHeshDocName
    {
        public short Id { get; set; }
        public string DocName { get; set; }
        public short? DocGroup { get; set; }
        public short? FixNumerator { get; set; }
        public int? FirstNumber { get; set; }
        public int? CurrentNumber { get; set; }
        public short? SalesDoc { get; set; }
        public int? RptFormat { get; set; }
        public string RptDocName { get; set; }
        public int? Copies { get; set; }
        public string TkindKod { get; set; }
        public string TkindFreeKod { get; set; }
        public bool? UpdateMelay { get; set; }
        public int? LocationId { get; set; }
    }
}

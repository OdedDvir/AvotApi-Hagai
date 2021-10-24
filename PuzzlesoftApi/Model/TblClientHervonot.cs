using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHervonot
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public decimal? MadadBasis { get; set; }
        public decimal? PriceBasis { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? LastMadad { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? BArchive { get; set; }
        public decimal? SumReturn { get; set; }
        public string Memo1 { get; set; }
        public decimal? SumReturnHome { get; set; }
        public decimal? SumReturnFamily { get; set; }
        public DateTime? DatePayFamily { get; set; }
        public bool? BDel { get; set; }
    }
}

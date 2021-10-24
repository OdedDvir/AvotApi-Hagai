using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblContractsActionLog
    {
        public int? ContractId { get; set; }
        public decimal? SumBefore { get; set; }
        public decimal? SumHilut { get; set; }
        public DateTime? Date1 { get; set; }
        public string Memo1 { get; set; }
        public int? Userid { get; set; }
        public string UserCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public decimal? MadadRateBefore { get; set; }
        public decimal? MadadRateAfter { get; set; }
        public DateTime? DateBefore { get; set; }
    }
}

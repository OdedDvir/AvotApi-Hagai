using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRate
    {
        public DateTime? Date1 { get; set; }
        public int? CoinId { get; set; }
        public decimal? Rate { get; set; }
        public int Id { get; set; }
        public string Kod1 { get; set; }
    }
}

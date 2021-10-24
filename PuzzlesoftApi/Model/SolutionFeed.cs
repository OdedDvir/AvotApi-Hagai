using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class SolutionFeed
    {
        public int Id { get; set; }
        public string SolFkod { get; set; }
        public string TradeNameShort { get; set; }
        public string TradeName { get; set; }
        public string SolFgroup { get; set; }
        public bool? Archive { get; set; }
    }
}

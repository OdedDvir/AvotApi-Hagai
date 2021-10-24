using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ExchangeRate
    {
        public int Id { get; set; }
        public DateTime? RateDate { get; set; }
        public decimal? Rate { get; set; }
    }
}

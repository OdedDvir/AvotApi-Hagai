using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QChargesSum
    {
        public string ChargeName { get; set; }
        public int? ClientId { get; set; }
        public decimal? TotalSum { get; set; }
        public double? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}

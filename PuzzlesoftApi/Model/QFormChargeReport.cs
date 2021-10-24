using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QFormChargeReport
    {
        public string ChargeName { get; set; }
        public string ChargeKod { get; set; }
        public DateTime? ChargeDate { get; set; }
        public string Kod { get; set; }
        public string NameView { get; set; }
        public decimal? TotalSum { get; set; }
        public float? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Description { get; set; }
        public int? ReportId { get; set; }
        public short? LocationId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblChargesReport
    {
        public TblChargesReport()
        {
            FormChargeReportDetails = new HashSet<FormChargeReportDetail>();
        }

        public int Id { get; set; }
        public int? ParitId { get; set; }
        public string ParitName { get; set; }
        public decimal? ParitPrice { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public string ChargeMonth { get; set; }
        public DateTime? DateCharge { get; set; }
        public bool? Locked { get; set; }
        public short? Calculate { get; set; }
        public short? LocationId { get; set; }

        public virtual ICollection<FormChargeReportDetail> FormChargeReportDetails { get; set; }
    }
}

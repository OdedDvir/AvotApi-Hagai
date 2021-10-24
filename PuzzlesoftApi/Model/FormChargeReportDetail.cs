using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormChargeReportDetail
    {
        public int Id { get; set; }
        public string DayarKod { get; set; }
        public string DayarName { get; set; }
        public float? Quantity { get; set; }
        public short? ChargeDays { get; set; }
        public decimal? ChargeSum { get; set; }
        public string Comments { get; set; }
        public int? ReportId { get; set; }

        public virtual TblChargesReport Report { get; set; }
    }
}

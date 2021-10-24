using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPurchaseDetail
    {
        public int Id { get; set; }
        public string ParitKod { get; set; }
        public short? NCount { get; set; }
        public double? DPrice { get; set; }
        public double? DPriceAll { get; set; }
        public string MakatParit { get; set; }
        public int? FormPurchaseId { get; set; }
    }
}

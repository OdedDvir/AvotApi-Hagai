using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugAcceptDetail
    {
        public string DrugName { get; set; }
        public DateTime? Date1 { get; set; }
        public double? Price { get; set; }
        public double? PriceAll { get; set; }
        public int? AcceptId { get; set; }
        public int? Num1 { get; set; }
        public int? MirshamId { get; set; }
    }
}

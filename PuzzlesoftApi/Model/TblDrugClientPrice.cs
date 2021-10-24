using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugClientPrice
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string DrugKod { get; set; }
        public string DrugName { get; set; }
        public double? Price1 { get; set; }
    }
}

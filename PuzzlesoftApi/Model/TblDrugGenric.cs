using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugGenric
    {
        public string DrugKod { get; set; }
        public int? GenricKod { get; set; }
        public string GenricName { get; set; }
        public float? GenricNum { get; set; }
        public string GenricUnit { get; set; }
        public string Ratio1 { get; set; }
        public int Id { get; set; }
        public int? DrugId { get; set; }
    }
}

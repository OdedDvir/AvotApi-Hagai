using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QDrugLastPrice
    {
        public int? ClientId { get; set; }
        public int? DocNameId { get; set; }
        public string ParitKod { get; set; }
        public double? Price { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}

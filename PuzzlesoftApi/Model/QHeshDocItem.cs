using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QHeshDocItem
    {
        public string ParitKod { get; set; }
        public string NameView { get; set; }
        public double? Price { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? MahsanId { get; set; }
        public string Mahsan { get; set; }
        public int SapakId { get; set; }
        public float? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public int? DocNameId { get; set; }
    }
}

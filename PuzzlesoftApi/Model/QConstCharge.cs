using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QConstCharge
    {
        public int? ParitId { get; set; }
        public string ParitName { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? ClientId { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? Active { get; set; }
        public double? SalePrice { get; set; }
        public int Id { get; set; }
        public string Kod { get; set; }
        public int? KodDayar { get; set; }
        public string NameView { get; set; }
        public string Coin { get; set; }
        public bool? Archive { get; set; }
    }
}

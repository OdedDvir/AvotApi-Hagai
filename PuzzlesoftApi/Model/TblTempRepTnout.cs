using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTempRepTnout
    {
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string IdCard { get; set; }
        public int? NDays { get; set; }
        public int? MahlakaId { get; set; }
        public int? SponserId { get; set; }
        public string SponserKod { get; set; }
        public int? SponserMahoz { get; set; }
        public int? TifkudId { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public decimal? Price1 { get; set; }
        public int Id { get; set; }
        public int? NCount { get; set; }
        public decimal? ParitPrice { get; set; }
        public bool? BIshpuz { get; set; }
    }
}

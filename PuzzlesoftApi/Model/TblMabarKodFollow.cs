using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMabarKodFollow
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public decimal? PriceBeforeKod { get; set; }
        public DateTime? DateDocsToMabar { get; set; }
        public bool? BDocsToFamily { get; set; }
        public string Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblEnergy
    {
        public int Id { get; set; }
        public string Kod1 { get; set; }
        public int? LocationId { get; set; }
        public decimal? DSumAll { get; set; }
        public decimal? DCount { get; set; }
        public string Memo1 { get; set; }
        public int? UserId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? Date1 { get; set; }
        public string Asmachta { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QTnuot2
    {
        public string NameView { get; set; }
        public int Id { get; set; }
        public int? ManaId { get; set; }
        public string TkindKod { get; set; }
        public string Asmachta1 { get; set; }
        public string Asmachta2 { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Details { get; set; }
        public decimal? SumHova { get; set; }
        public decimal? SumZchut { get; set; }
        public string HeshKod { get; set; }
        public bool? BZmani { get; set; }
        public int? DocId { get; set; }
        public bool? BHashavshevet { get; set; }
        public int? HeshId { get; set; }
    }
}

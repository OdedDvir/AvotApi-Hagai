using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTnuot
    {
        public int Id { get; set; }
        public string Asmachta1 { get; set; }
        public string Asmachta2 { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Details { get; set; }
        public decimal? PaySum { get; set; }
        public int? CardHeshId { get; set; }
        public int? ClientHeshId { get; set; }
        public decimal? MahamSum { get; set; }
        public short? DocId { get; set; }
        public bool? BZmani { get; set; }
        public int? RevahCaptionId { get; set; }
        public int? KodMiunId { get; set; }
        public short? MahamKindId { get; set; }
        public int? ManaId { get; set; }
    }
}

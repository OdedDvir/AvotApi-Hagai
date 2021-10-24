using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ClientDetailShort
    {
        public int Id { get; set; }
        public short? Locationid { get; set; }
        public short? MainKind { get; set; }
        public bool? Archive { get; set; }
        public string Nameview { get; set; }
        public DateTime? DateMahlaka { get; set; }
        public int TifkudStatusId { get; set; }
        public string TifkudStatus { get; set; }
        public short? MahlakaId { get; set; }
        public DateTime? DateEnter { get; set; }
        public DateTime? DateIshpuz { get; set; }
        public string Mahlaka { get; set; }
        public string Properties { get; set; }
    }
}

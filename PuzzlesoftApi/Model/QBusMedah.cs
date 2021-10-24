using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QBusMedah
    {
        public int Id { get; set; }
        public DateTime? MedahDate { get; set; }
        public string Theme { get; set; }
        public string Medah { get; set; }
        public int? ClientId { get; set; }
        public string NameView { get; set; }
        public string Hatsmada { get; set; }
        public decimal? Sum1 { get; set; }
        public string Asmachta { get; set; }
        public string Phone1 { get; set; }
    }
}

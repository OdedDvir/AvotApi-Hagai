using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BusMedah
    {
        public int Id { get; set; }
        public string Medah { get; set; }
        public DateTime? MedahDate { get; set; }
        public int? ClientId { get; set; }
        public int? ThemeId { get; set; }
        public decimal? Sum { get; set; }
        public string Asmachta { get; set; }
        public short? Hatsmada { get; set; }
        public DateTime? MedahDate2 { get; set; }
        public string RoomName { get; set; }
        public string Mahlaka { get; set; }
        public string Medah2 { get; set; }
        public bool BDel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefCharge
    {
        public int Id { get; set; }
        public string ChargeName { get; set; }
        public short? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? HatsmadaId { get; set; }
        public bool? Maham { get; set; }
        public string Description { get; set; }
    }
}

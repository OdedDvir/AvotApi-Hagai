using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMahsanDetail
    {
        public int Id { get; set; }
        public string KodParit { get; set; }
        public float? MelayRest { get; set; }
        public int? MelayMin { get; set; }
        public int? MelayOpt { get; set; }
        public int? MahsanId { get; set; }
        public string KodparitOld { get; set; }
    }
}

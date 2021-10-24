using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TbldefMaintenance
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? MiunId { get; set; }
        public int? KodParit { get; set; }
        public string Comments { get; set; }
        public bool? Archive { get; set; }
    }
}

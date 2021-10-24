using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefEnterStatus
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public decimal? BasicPrice { get; set; }
        public int? NKind { get; set; }
        public int? ListId { get; set; }
        public bool? AirCond { get; set; }
        public bool? BDbl { get; set; }
        public bool? BSafe { get; set; }
        public bool? BTwoBeds { get; set; }
    }
}

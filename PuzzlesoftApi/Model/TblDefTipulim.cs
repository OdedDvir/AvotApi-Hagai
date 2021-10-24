using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefTipulim
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string KindKey { get; set; }
        public int? MainId { get; set; }
        public int? ThemeId { get; set; }
        public bool? BharshahaNurse { get; set; }
        public bool Bdel { get; set; }
        public string PriorityKey { get; set; }
    }
}

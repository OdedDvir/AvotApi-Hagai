using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TbldefparitmiunWeb
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public short ParentId { get; set; }
        public bool Archive { get; set; }
        public string HeshKod { get; set; }
        public string HeshKod2 { get; set; }
        public int UserIdCreate { get; set; }
        public int UserIdUpdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime TStampUpdate { get; set; }
        public string ItemEng { get; set; }
    }
}

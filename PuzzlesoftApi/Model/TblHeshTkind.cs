using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHeshTkind
    {
        public int Id { get; set; }
        public int? TkindId { get; set; }
        public int? HeshbonId { get; set; }
        public bool? Hova { get; set; }
        public bool? Main { get; set; }
        public short? Per { get; set; }

        public virtual TblTnuahKind Tkind { get; set; }
    }
}

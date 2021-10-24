using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTnuahKind
    {
        public TblTnuahKind()
        {
            TblHeshTkinds = new HashSet<TblHeshTkind>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string TkindName { get; set; }
        public string Details { get; set; }

        public virtual ICollection<TblHeshTkind> TblHeshTkinds { get; set; }
    }
}

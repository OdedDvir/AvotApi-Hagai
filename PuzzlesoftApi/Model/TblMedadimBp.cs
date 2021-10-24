using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimBp
    {
        public int RowId { get; set; }
        public int? Systol { get; set; }
        public int? Dyastol { get; set; }
        public string Notes { get; set; }
        public bool BDel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

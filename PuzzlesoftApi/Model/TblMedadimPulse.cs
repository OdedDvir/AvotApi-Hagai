using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimPulse
    {
        public int RowId { get; set; }
        public int? Pulse { get; set; }
        public bool? BSadir { get; set; }
        public string Notes { get; set; }
        public bool? BDel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

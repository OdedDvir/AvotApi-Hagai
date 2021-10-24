using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimWeight
    {
        public int RowId { get; set; }
        public double? Weight { get; set; }
        public string Notes { get; set; }
        public bool? BDel { get; set; }
        public bool CanntWeight { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

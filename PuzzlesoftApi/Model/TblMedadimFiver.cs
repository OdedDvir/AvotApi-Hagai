using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimFiver
    {
        public int RowId { get; set; }
        public double? Fiver { get; set; }
        public string Notes { get; set; }
        public string FiverWay { get; set; }
        public bool? BDel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

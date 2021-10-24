using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimPressB
    {
        public int RowId { get; set; }
        public string PressB { get; set; }
        public string Notes { get; set; }
        public bool? BDel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

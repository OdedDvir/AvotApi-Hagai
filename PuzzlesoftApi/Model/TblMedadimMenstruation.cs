using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimMenstruation
    {
        public int RowId { get; set; }
        public bool? Menstruation { get; set; }
        public string Notes { get; set; }
        public bool? BDel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

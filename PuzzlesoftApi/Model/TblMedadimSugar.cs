using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimSugar
    {
        public int RowId { get; set; }
        public int? Sugar { get; set; }
        public string Notes { get; set; }
        public bool? BDel { get; set; }
        public bool? SugarLevel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

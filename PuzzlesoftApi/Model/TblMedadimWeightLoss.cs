using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadimWeightLoss
    {
        public int RowId { get; set; }
        public string WeightLoss { get; set; }
        public string WeightLossId { get; set; }
        public bool BDel { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

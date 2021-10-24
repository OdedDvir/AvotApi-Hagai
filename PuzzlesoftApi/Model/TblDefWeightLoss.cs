using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefWeightLoss
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string ItemEng { get; set; }
        public int? OrdId { get; set; }
        public double? Precent { get; set; }
        public bool Bdel { get; set; }
    }
}

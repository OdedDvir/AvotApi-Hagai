using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblUserDrugSetting
    {
        public int? ClientId { get; set; }
        public int? ClassDrugtoInvite { get; set; }
        public double? MedDiscount { get; set; }
        public int? PriceListId { get; set; }
        public short? LocationId { get; set; }
        public bool? BUpSal { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblContractsHilutToYear
    {
        public int Id { get; set; }
        public int? ContractId { get; set; }
        public byte? Year1 { get; set; }
        public decimal? HilutPer { get; set; }
    }
}

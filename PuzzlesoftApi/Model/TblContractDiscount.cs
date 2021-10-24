using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblContractDiscount
    {
        public int Id { get; set; }
        public int? ContractId { get; set; }
        public decimal? Sum1 { get; set; }
        public DateTime? Date1 { get; set; }
        public string Memo1 { get; set; }
    }
}

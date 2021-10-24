using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblContractPayment
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public DateTime DatePayPlanned { get; set; }
        public double SumPayPlanned { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugTempList
    {
        public int Id { get; set; }
        public string DrugName { get; set; }
        public string DrugKod { get; set; }
        public string Minun { get; set; }
        public short? Num1Old { get; set; }
        public string DrugFormat { get; set; }
        public int? ClientId { get; set; }
        public int? UserCreate { get; set; }
        public bool BPurchase { get; set; }
        public float? Num1 { get; set; }
        public string DrugComments { get; set; }
        public long? FormPkudotId { get; set; }
        public string DrugTypeToInvite { get; set; }
    }
}

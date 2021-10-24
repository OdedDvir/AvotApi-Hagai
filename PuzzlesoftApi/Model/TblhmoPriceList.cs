using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblhmoPriceList
    {
        public int Id { get; set; }
        public int KupaId { get; set; }
        public int TnuaId { get; set; }
        public int TifkudStatusId { get; set; }
        public string PriceKod { get; set; }
        public string PriceDetails { get; set; }
        public double SumOfPrice { get; set; }
        public string Reason { get; set; }
    }
}

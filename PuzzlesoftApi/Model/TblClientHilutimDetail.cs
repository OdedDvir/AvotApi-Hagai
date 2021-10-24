using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHilutimDetail
    {
        public int Id { get; set; }
        public int MaslulId { get; set; }
        public DateTime Date1 { get; set; }
        public decimal NDays { get; set; }
        public decimal Sum1 { get; set; }
        public decimal MamahmRatio { get; set; }
        public decimal SumMaham { get; set; }
        public decimal SumAll { get; set; }
        public decimal SumWithMadad { get; set; }
        public short? ActionType { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? Date3 { get; set; }
        public short Kind1 { get; set; }
        public decimal Madad { get; set; }
        public decimal Dolar1 { get; set; }
        public bool? BMakeReCalcS { get; set; }
        public int UserCreateId { get; set; }
        public int MimsakId { get; set; }
        public DateTime TStamp { get; set; }
        public int BNnn { get; set; }
    }
}

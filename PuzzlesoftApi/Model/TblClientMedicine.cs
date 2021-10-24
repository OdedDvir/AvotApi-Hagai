using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientMedicine
    {
        public int? ClientId { get; set; }
        public int Id { get; set; }
        public short? TradeKindId { get; set; }
        public string TradeName { get; set; }
        public int? MedMonthly { get; set; }
        public short? CapsulesNum { get; set; }
        public string CapsuleName { get; set; }
        public short? DayMinun { get; set; }
        public short? DaysNum { get; set; }
        public short? TakeWay { get; set; }
        public DateTime? Date1 { get; set; }
        public string TimeTake { get; set; }
        public bool? NoLimit { get; set; }
        public bool? Deleted { get; set; }
        public string Subject1 { get; set; }
        public string UserCreate { get; set; }
        public DateTime? SCurrentDate { get; set; }
        public string Time1 { get; set; }
        public string Val10 { get; set; }
    }
}

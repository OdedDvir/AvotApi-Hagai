using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ReportMabar494
    {
        public int Id { get; set; }
        public short? KodMahoz { get; set; }
        public int? TekenMita { get; set; }
        public int? ClientId { get; set; }
        public DateTime? KabalaDate { get; set; }
        public string IshpuzDate { get; set; }
        public string ReturnDate { get; set; }
        public string HospitalKod { get; set; }
        public DateTime? LeaveDate { get; set; }
        public short? LeaveKind { get; set; }
        public float? DaysInMonth { get; set; }
        public decimal? SumPay { get; set; }
        public decimal? DayPrice { get; set; }
        public short? Month { get; set; }
        public short? Year { get; set; }
        public string DiurKind { get; set; }
    }
}

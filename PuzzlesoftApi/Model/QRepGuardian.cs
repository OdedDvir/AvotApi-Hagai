using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QRepGuardian
    {
        public int? Id { get; set; }
        public string GuardianAddress { get; set; }
        public string GuardianName { get; set; }
        public string Idcard { get; set; }
        public DateTime? DateNeedEnter { get; set; }
        public string RoomName { get; set; }
        public string Kupa { get; set; }
        public string GuardianPhone1 { get; set; }
        public string GuardianPhone2 { get; set; }
        public string GuardianPhone3 { get; set; }
        public string GuardianFax { get; set; }
        public string NameView { get; set; }
        public string DayarKod { get; set; }
        public short? MainKind { get; set; }
        public string GuardianKirva { get; set; }
        public bool? Archive { get; set; }
        public short? MahlakaId { get; set; }
        public string Mahlaka { get; set; }
        public short? LocationId { get; set; }
        public string DayarCellular { get; set; }
        public string Interkum { get; set; }
        public string CarNum { get; set; }
        public string DayarPhone { get; set; }
        public string Kind1 { get; set; }
        public string Kind2 { get; set; }
        public int ClientId { get; set; }
        public string NameViewZug { get; set; }
        public string DayarCellular2 { get; set; }
        public string DayarCellular3 { get; set; }
        public string GuardianField { get; set; }
        public string DayarFax { get; set; }
        public string DayarDetails { get; set; }
    }
}

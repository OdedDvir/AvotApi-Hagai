using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHeshSetting
    {
        public int Id { get; set; }
        public bool? CollectSame { get; set; }
        public bool? HeshCoin { get; set; }
        public bool? HeshDayarKod { get; set; }
        public bool? HeshDescription { get; set; }
        public bool? HeshNotes { get; set; }
        public bool? HeshOsek { get; set; }
        public bool? HeshParitKod { get; set; }
        public bool? HeshPriceSum { get; set; }
        public bool? HeshPriceUnit { get; set; }
        public bool? UpdateMelay { get; set; }
        public bool? RoundSum { get; set; }
        public int? LocationId { get; set; }
        public bool? BZugCaption { get; set; }
        public bool? BSetChargesUnActiveOnDoc { get; set; }
        public bool? CollectDrug { get; set; }
        public bool? CollectByMiun { get; set; }
        public bool? IncludeGroupAndDetails { get; set; }
    }
}

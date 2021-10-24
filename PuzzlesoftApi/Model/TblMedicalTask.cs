using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedicalTask
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Workers { get; set; }
        public string TaskTheme { get; set; }
        public string Description { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string Comments { get; set; }
        public short? LocationId { get; set; }
        public int? UserCreate { get; set; }
        public int? YeshivaId { get; set; }
        public string FormKey { get; set; }
        public int? FormTypeId { get; set; }
        public int? Frequency { get; set; }
        public short? DoneStatus { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? Date2 { get; set; }
        public short? JobId { get; set; }
        public string Target { get; set; }
        public bool? BDel { get; set; }
        public int? FormId { get; set; }
        public bool? BTaskKind { get; set; }
        public int? UserDoneId { get; set; }
        public int? MedicalGroupDone { get; set; }
        public DateTime? DateDone { get; set; }
        public DateTime? TStmpDateDone { get; set; }
        public int? PlanId { get; set; }
        public int MahlakaId { get; set; }
    }
}

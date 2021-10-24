using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMeducalTask
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public bool BKindId { get; set; }
        public string TaskTheme { get; set; }
        public string Description { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public int Frequency { get; set; }
        public string SpesificWorKers { get; set; }
        public string SubjectWorkers { get; set; }
        public string Comments { get; set; }
        public bool BClosed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int UserClosedId { get; set; }
        public int TaskKindId { get; set; }
        public int FormId { get; set; }
        public int MedicalGroupDone { get; set; }
        public string Target { get; set; }
        public bool BDel { get; set; }
        public int UserCreateId { get; set; }
        public int UserUpdateId { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime? TStampUpdate { get; set; }
    }
}

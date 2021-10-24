using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientMedicalImg
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int KabalaId { get; set; }
        public int? FormId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string Comment { get; set; }
        public DateTime Tstamp { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool Bdel { get; set; }
        public string InfectiousDiseases { get; set; }
        public string InfectiousDiseasesId { get; set; }
        public string Mobility { get; set; }
        public int? MobilityId { get; set; }
        public string NeedOxygen { get; set; }
        public string PresumptiveDiagnosis { get; set; }
        public string ActivityBreakdownProblems { get; set; }
        public string QuestionXrays { get; set; }
        public string RoomNum { get; set; }
        public int StationId { get; set; }
        public int BodyPartId { get; set; }
        public int ExaminationId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTestDinko
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? KabalaId { get; set; }
        public int BdikaId { get; set; }
        public int? FormId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string Comment { get; set; }
        public DateTime? Tstamp { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool Bdel { get; set; }
        public string InfectiousDiseases { get; set; }
        public string Mobility { get; set; }
        public string NeedOxygen { get; set; }
        public string PresumptiveDiagnosis { get; set; }
        public string ActivityBreakdownProblems { get; set; }
        public string QuestionXrays { get; set; }
        public int? InfectiousDiseasesId { get; set; }
        public int? MobilityId { get; set; }
        public int? NeedOxygenId { get; set; }
        public int? BdikaDetailsId { get; set; }
        public int? BdikaId2 { get; set; }
        public int? BdikaDetailsId2 { get; set; }
        public int? DinkoNum { get; set; }
        public string RoomNum { get; set; }
        public bool BArchive { get; set; }
        public string Side { get; set; }
    }
}

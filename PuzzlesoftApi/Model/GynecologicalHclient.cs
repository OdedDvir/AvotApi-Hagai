using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class GynecologicalHclient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime? Datefirstperiod { get; set; }
        public DateTime? Lastmenstruationdate { get; set; }
        public int? CycleLength { get; set; }
        public int? Flow { get; set; }
        public string Pms { get; set; }
        public string Hypomenorrhea { get; set; }
        public string StdorPid { get; set; }
        public int? AgeMenopause { get; set; }
        public string Symptoms { get; set; }
        public string PastHrt { get; set; }
        public int? PastHrtid { get; set; }
        public string CurrentHrt { get; set; }
        public int? CurrentHrtid { get; set; }
        public int? G { get; set; }
        public int? P { get; set; }
        public int? M { get; set; }
        public int? Ab { get; set; }
        public string ProblemsPregnancy { get; set; }
        public string ProblemsPregnancyId { get; set; }
        public string ProblemsDelivery { get; set; }
        public string ProblemsDeliveryId { get; set; }
        public string ContraceptionCurrent { get; set; }
        public int? ContraceptionCurrentId { get; set; }
        public string ContraceptionPast { get; set; }
        public int? ContraceptionPastId { get; set; }
        public string FertilityProblems { get; set; }
        public string FertilityProblemsId { get; set; }
        public string Endometriosis { get; set; }
        public string EndometriosisId { get; set; }
        public string Treatments { get; set; }
        public string TreatmentsId { get; set; }
        public bool Bdel { get; set; }
        public int? F { get; set; }
        public DateTime Tstamp { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientInfection
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public int? ClientId { get; set; }
        public string Findings { get; set; }
        public string InfectionSource { get; set; }
        public DateTime? DateG { get; set; }
        public DateTime? DateR { get; set; }
        public int FindingsId { get; set; }
        public int InfectionSourceId { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool BDel { get; set; }
        public DateTime TStamp { get; set; }
        public string Insulation { get; set; }
        public int InsulationId { get; set; }
        public string Comments { get; set; }
        public DateTime? DateTarbitFirst { get; set; }
        public int? SikorId { get; set; }
        public string SikorName { get; set; }
        public string ArriveFrom { get; set; }
        public int? InfectedPlace { get; set; }
        public string InfectedPlaceName { get; set; }
        public string MahlakaR { get; set; }
        public string MossadRep { get; set; }
        public int? IshpuzId { get; set; }
        public string IshpuzName { get; set; }
        public string StaffPres { get; set; }
        public DateTime? DateBmLast { get; set; }
        public double? ResultBmLast { get; set; }
        public string Pcr { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public int? KindStandId { get; set; }
        public string KindStandName { get; set; }
        public string HodgeTest { get; set; }
        public string FindDesc { get; set; }
        public DateTime? DateTarbitScheduled { get; set; }
    }
}

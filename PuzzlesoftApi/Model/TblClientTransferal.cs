using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTransferal
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Place1 { get; set; }
        public string Date1 { get; set; }
        public string Typ1 { get; set; }
        public string Typ2 { get; set; }
        public string Reason1 { get; set; }
        public string Result1 { get; set; }
        public int? FormId { get; set; }
        public bool? Locked { get; set; }
        public bool? Urgent { get; set; }
        public bool? IncludeTifkud { get; set; }
        public bool? IncludeContactMen { get; set; }
        public bool? IncludeAvhanot { get; set; }
        public bool? IncludeDrugs { get; set; }
        public bool? IncludeRegishut { get; set; }
        public bool? IncludeAvhanotOld { get; set; }
        public bool? IncludeSigns { get; set; }
        public bool? IncludeLastTifkud { get; set; }
        public bool? IncludeBm { get; set; }
        public bool? NcludeLastTifkud { get; set; }
        public bool? BDel { get; set; }
        public string UserCreate { get; set; }
        public bool IncludeKabalaReka { get; set; }
        public bool? PrintFormat { get; set; }
        public bool? IncludeLastFollowDoctor { get; set; }
        public bool? IncludeAddress { get; set; }
        public bool? IncludeHisun { get; set; }
        public bool? IncludeBlister { get; set; }
        public bool IncludeLastBdika { get; set; }
        public bool? IncludePhizio { get; set; }
        public bool? BIncludeLastFollowNurse { get; set; }
        public bool? IncludeLastFollowNurse { get; set; }
        public bool? IncludeLstDctrYzmSikum { get; set; }
        public bool? IncludeClientImage { get; set; }
        public bool IncludeInfections { get; set; }
        public bool? BIncludeLastKeev { get; set; }
        public bool? IncludeLastTenFollows { get; set; }
        public bool? IncludeLastKeev { get; set; }
        public bool IncludeDietDrug { get; set; }
        public bool BIncludeIshpuzim { get; set; }
    }
}

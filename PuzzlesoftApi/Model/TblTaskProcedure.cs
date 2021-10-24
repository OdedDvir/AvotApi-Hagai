using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTaskProcedure
    {
        public int Id { get; set; }
        public string ProcedureKey { get; set; }
        public string ProcedureDesc { get; set; }
        public int Frequency { get; set; }
        public string StatusListId { get; set; }
        public string StatusList { get; set; }
        public string ProfileListId { get; set; }
        public string ProfileList { get; set; }
        public bool Bdel { get; set; }
        public int NumOfKabala { get; set; }
        public string KindFrequency { get; set; }
        public bool BNotEdit { get; set; }
        public string FrequencyDesc { get; set; }
        public bool BDanger { get; set; }
        public string AvhanaKod { get; set; }
        public string PropertiesList { get; set; }
        public int NumOfIshpuz { get; set; }
        public int NumOfKmahlaka { get; set; }
    }
}

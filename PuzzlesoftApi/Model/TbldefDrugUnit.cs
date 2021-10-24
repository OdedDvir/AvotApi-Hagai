using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TbldefDrugUnit
    {
        public int Id { get; set; }
        public string DrugMinunType { get; set; }
        public string SeegnalCode { get; set; }
        public string SeegnalUnitName { get; set; }
        public bool Bdel { get; set; }
        public DateTime Tstampcreate { get; set; }
        public DateTime Tstampupdate { get; set; }
        public int Useridcreate { get; set; }
        public int Useridupdate { get; set; }
    }
}

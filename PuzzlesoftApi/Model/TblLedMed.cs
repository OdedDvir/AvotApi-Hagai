using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblLedMed
    {
        public int Id { get; set; }
        public string DrugKod { get; set; }
        public string ReasonGive { get; set; }
        public string LedImport { get; set; }
        public string LeviT { get; set; }
        public long? Usercreateid { get; set; }
        public string Usercreate { get; set; }
        public DateTime? TsDate { get; set; }
        public bool? Bdel { get; set; }
    }
}

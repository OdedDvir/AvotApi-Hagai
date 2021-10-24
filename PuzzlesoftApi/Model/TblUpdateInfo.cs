using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblUpdateInfo
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public DateTime? Date1 { get; set; }
        public string UpdateDetails { get; set; }
        public string Href { get; set; }
        public string Subject1 { get; set; }
        public string Comments { get; set; }
        public string UserDelete { get; set; }
        public string VersionNum { get; set; }
    }
}

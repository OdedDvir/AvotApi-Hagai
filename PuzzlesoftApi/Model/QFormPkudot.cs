using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QFormPkudot
    {
        public string NameView { get; set; }
        public short? RecKind { get; set; }
        public short? RecStatus { get; set; }
        public string UserName { get; set; }
        public DateTime? Date1 { get; set; }
        public string Item { get; set; }
        public string NurseNameStart { get; set; }
        public string NurseNameStop { get; set; }
        public DateTime? DateStopDoctor { get; set; }
        public DateTime? DateStopNurse { get; set; }
        public DateTime? DateStartNurse { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormDynItm
    {
        public int Id { get; set; }
        public int? FormId { get; set; }
        public string SCap { get; set; }
        public string SIm { get; set; }
        public string STyp { get; set; }
        public string SMin { get; set; }
        public string SMax { get; set; }
        public int? NOrd { get; set; }
    }
}

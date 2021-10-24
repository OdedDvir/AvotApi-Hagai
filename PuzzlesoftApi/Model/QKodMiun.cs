using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QKodMiun
    {
        public int Id { get; set; }
        public string KodMiunName { get; set; }
        public string RevahCaption { get; set; }
        public string MahamKind { get; set; }
        public float? PerMaham { get; set; }
    }
}

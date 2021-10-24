using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblKodMiun
    {
        public int Id { get; set; }
        public string KodMiunName { get; set; }
        public int? RevahCaptionId { get; set; }
        public int? MahamKindId { get; set; }
        public float? PerMaham { get; set; }
        public int? DocId { get; set; }
    }
}

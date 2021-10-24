using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefTestRisk
    {
        public long? TestId { get; set; }
        public int? MinPoint { get; set; }
        public int? MaxPoint { get; set; }
        public int? NumRisk { get; set; }
        public long? ProblemId { get; set; }
        public string TargetId { get; set; }
        public int? Index1 { get; set; }
    }
}

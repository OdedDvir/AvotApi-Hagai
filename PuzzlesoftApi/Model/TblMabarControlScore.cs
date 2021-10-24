using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMabarControlScore
    {
        public int Id { get; set; }
        public int LocId { get; set; }
        public double? LastScore { get; set; }
        public double? TargetScore { get; set; }
        public double? EstimateScore { get; set; }
        public double? FinalScore { get; set; }
        public double MainId { get; set; }
    }
}

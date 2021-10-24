using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class SolutionFeedClient
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public int? Clientid { get; set; }
        public int Formid { get; set; }
        public int? SolFid { get; set; }
        public string Amount { get; set; }
        public int? Provision { get; set; }
        public int? FeedingTubeId { get; set; }
        public int? FeedingId { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public bool? Archive { get; set; }
        public int? SolutionFeed { get; set; }
        public string FabricId { get; set; }
        public string FabricName { get; set; }
        public int? FeedType { get; set; }
        public int? KindSolution { get; set; }
        public string Comment { get; set; }
        public string DrugKod { get; set; }
        public string AmountDrug { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Feeding
    {
        public int Id { get; set; }
        public string FeedingTubeName { get; set; }
        public string Type { get; set; }
        public int? FeedTypeId { get; set; }
        public string FeedingTubeName2 { get; set; }
        public bool Archive { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FeedBreakClient
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string TimeB { get; set; }
        public string TimeE { get; set; }
        public int? Clientid { get; set; }
        public int Formid { get; set; }
        public int? SolFid { get; set; }
        public string Reason { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public bool? Archive { get; set; }
        public string DrugKod { get; set; }
    }
}

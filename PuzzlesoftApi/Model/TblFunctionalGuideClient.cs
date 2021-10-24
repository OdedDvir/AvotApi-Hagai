using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFunctionalGuideClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date1 { get; set; }
        public int MedicalGroupId { get; set; }
        public bool Bdel { get; set; }
        public bool Bstop { get; set; }
        public int UserIdCreate { get; set; }
        public int? UserIdUpdate { get; set; }
        public int? UserIdDelete { get; set; }
        public int? UserIdStop { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime? TStampUpdate { get; set; }
        public DateTime? TStampDelete { get; set; }
        public DateTime? TStampStop { get; set; }
        public bool Barchive { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientIshpuzim
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Hospital { get; set; }
        public string Mahlaka { get; set; }
        public string Doctor1 { get; set; }
        public string DateS { get; set; }
        public string DateE { get; set; }
        public string Reason { get; set; }
        public string Results { get; set; }
        public int? UserIdcreate { get; set; }
        public int? LeaveKindKod { get; set; }
    }
}

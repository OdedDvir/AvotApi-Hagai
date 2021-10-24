using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefNursingPlansProblem
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? MainId { get; set; }
        public bool? Archive { get; set; }
        public DateTime? TStamp { get; set; }
        public int? Userid { get; set; }
    }
}

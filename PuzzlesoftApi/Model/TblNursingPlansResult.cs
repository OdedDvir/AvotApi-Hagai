using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblNursingPlansResult
    {
        public DateTime? Date1 { get; set; }
        public string Results { get; set; }
        public int? PlanId { get; set; }
        public string Target { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime? TStamp { get; set; }
        public bool Archive { get; set; }
    }
}

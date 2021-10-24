using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QYeshivaParticipate
    {
        public string WorkerName { get; set; }
        public int Id { get; set; }
        public int? YeshivaId { get; set; }
        public int? PlanId { get; set; }
        public int? WorkerId { get; set; }
        public short? JobId { get; set; }
        public string Skira { get; set; }
        public string Job { get; set; }
        public bool? BDel { get; set; }
        public string SkiraDate { get; set; }
    }
}

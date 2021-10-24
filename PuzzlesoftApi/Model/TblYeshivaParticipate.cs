using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblYeshivaParticipate
    {
        public int Id { get; set; }
        public int? YeshivaId { get; set; }
        public int? PlanId { get; set; }
        public int? WorkerId { get; set; }
        public short? JobId { get; set; }
        public string Skira { get; set; }
        public string Target { get; set; }
        public string WorkerName { get; set; }
        public DateTime? SkiraDate { get; set; }
        public bool? Bdel { get; set; }
    }
}

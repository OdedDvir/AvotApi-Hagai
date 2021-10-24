using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMaintenanceOrder
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Theme { get; set; }
        public string Comments1 { get; set; }
        public string Place1 { get; set; }
        public int? MaintenanceId { get; set; }
        public int? UserId { get; set; }
        public bool? BDone { get; set; }
        public string DoneDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMaintenanceCrm
    {
        public int Id { get; set; }
        public int? Mainid { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Comments { get; set; }
        public int? Status { get; set; }
        public int? UserId { get; set; }
        public string UserCreated { get; set; }
        public DateTime? Tstamp { get; set; }
        public bool? Bdel { get; set; }
        public int? Action { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTreatmentNotDone
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public string UserCreate { get; set; }
        public int? TreatmentId { get; set; }
        public string Description { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? BDel { get; set; }
    }
}

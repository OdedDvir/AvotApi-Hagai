using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHospitalVisit
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public string Hospital { get; set; }
        public string Visitor { get; set; }
        public bool? Archive { get; set; }
        public bool? BDel { get; set; }
    }
}

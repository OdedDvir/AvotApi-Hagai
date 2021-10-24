using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDoctorTime
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public int? YomanId { get; set; }
        public int? NDay { get; set; }
        public DateTime? Time1 { get; set; }
        public DateTime? Time2 { get; set; }
        public int? NTorType { get; set; }
        public int? NTorItem { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPkudotConfirmation
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? TimeIn { get; set; }
        public string OrderText { get; set; }
        public int? OrderId { get; set; }
        public int? MahlakaId { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? ReadTime { get; set; }
        public int? WorkerId { get; set; }
        public int? ActionKind { get; set; }
        public bool? BDel { get; set; }
        public string OrderKind { get; set; }
    }
}

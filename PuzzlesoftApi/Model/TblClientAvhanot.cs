using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientAvhanot
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Theme { get; set; }
        public int? KindId { get; set; }
        public string DateSOld { get; set; }
        public string Place { get; set; }
        public string DateEOld { get; set; }
        public string Description { get; set; }
        public string AvhanaKod { get; set; }
        public string Status { get; set; }
        public int? RelatedId { get; set; }
        public bool? BMain { get; set; }
        public short? Priority { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public string Position { get; set; }
        public string Urgentcy { get; set; }
        public int? KabalaId { get; set; }
        public string DoctorName { get; set; }
        public string UserCreate { get; set; }
        public bool? BDel { get; set; }
        public int? NConv { get; set; }
        public bool? BConv { get; set; }
        public bool? BConv2 { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? DateE { get; set; }
        public int? BackClientId { get; set; }
        public int FormId { get; set; }
        public string StopReason { get; set; }
        public string DescReason { get; set; }
    }
}

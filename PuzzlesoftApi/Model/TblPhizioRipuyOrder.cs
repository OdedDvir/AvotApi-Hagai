using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPhizioRipuyOrder
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId1 { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? DateE { get; set; }
        public int? SubjectId { get; set; }
        public string Advice1 { get; set; }
        public int? RecStatus { get; set; }
        public int? UserId2 { get; set; }
        public string UserCreate2 { get; set; }
        public DateTime? TStamp { get; set; }
        public string Advice2 { get; set; }
        public int? MedicalGroupId { get; set; }
        public bool? BDel { get; set; }
        public int? MedicalGroupId2 { get; set; }
        public bool? IsOk { get; set; }
        public int UserIdOk { get; set; }
        public DateTime? DateOk { get; set; }
    }
}

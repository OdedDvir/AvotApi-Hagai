using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFollowUpMedical
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date1 { get; set; }
        public string Val { get; set; }
        public short? SubjectId { get; set; }
        public int UserIdcreate { get; set; }
        public int UserIdupdate { get; set; }
        public DateTime TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public int? GroupId { get; set; }
        public bool? BEdit { get; set; }
        public int? NConv { get; set; }
        public bool? BDel { get; set; }
        public int? FormId { get; set; }
        public int KabalaId { get; set; }
    }
}

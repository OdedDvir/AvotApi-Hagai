using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblYoman
    {
        public int Id { get; set; }
        public string Name1 { get; set; }
        public int? DoctorId { get; set; }
        public int? Subject1 { get; set; }
        public int? Subject2 { get; set; }
        public int? Subject3 { get; set; }
        public int? Subject4 { get; set; }
        public bool? BArchive { get; set; }
        public int? NLevel { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
        public string Memo3 { get; set; }
        public int? CompanyId { get; set; }
    }
}

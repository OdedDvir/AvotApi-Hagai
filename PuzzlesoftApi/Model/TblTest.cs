using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTest
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public int? UserIdcreate { get; set; }
        public bool? Locked { get; set; }
        public bool? Archive { get; set; }
        public int? NKind { get; set; }
        public string Desc { get; set; }
        public int? CorrectMin { get; set; }
        public int? CorrectMax { get; set; }
    }
}

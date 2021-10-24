using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBdikot
    {
        public int Id { get; set; }
        public string BdikaName { get; set; }
        public string BdikaTreeSrc { get; set; }
        public int? UserIdcreate { get; set; }
        public bool? Locked { get; set; }
        public bool? Archive { get; set; }
    }
}

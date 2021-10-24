using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblUpdate
    {
        public int Id { get; set; }
        public DateTime? TStamp { get; set; }
        public string File1 { get; set; }
        public string Dest { get; set; }
        public int? Status { get; set; }
        public string Version { get; set; }
    }
}

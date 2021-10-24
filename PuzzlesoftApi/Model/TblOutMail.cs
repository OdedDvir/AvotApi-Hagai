using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblOutMail
    {
        public int Id { get; set; }
        public string SendTo { get; set; }
        public string Subject1 { get; set; }
        public string Message1 { get; set; }
        public bool? IsSent { get; set; }
        public DateTime? TStamp { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTakziv
    {
        public int Id { get; set; }
        public string TreeName { get; set; }
        public string TreeSrc { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public bool? Locked { get; set; }
        public string SYear { get; set; }
    }
}

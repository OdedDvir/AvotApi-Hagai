using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblSm
    {
        public int Id { get; set; }
        public string SMsg { get; set; }
        public string SendTo { get; set; }
        public bool? BSent { get; set; }
    }
}

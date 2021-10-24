using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class MedGroupAtc
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string KodAtc { get; set; }
        public double? Ddd { get; set; }
        public bool Bdel { get; set; }
    }
}

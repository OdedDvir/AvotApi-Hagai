using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefNehalim
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name1 { get; set; }
        public string Description { get; set; }
        public string Kind1 { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool? BDel { get; set; }
    }
}

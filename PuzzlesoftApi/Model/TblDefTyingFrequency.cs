using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefTyingFrequency
    {
        public int Id { get; set; }
        public int MainId { get; set; }
        public string Item { get; set; }
        public bool? Bdel { get; set; }
    }
}

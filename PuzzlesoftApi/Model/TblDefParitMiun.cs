using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefParitMiun
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string HeshIn { get; set; }
        public string HeshOut { get; set; }
        public bool? BCharge { get; set; }
        public bool? Archive { get; set; }
    }
}

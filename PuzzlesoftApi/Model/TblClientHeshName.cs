using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHeshName
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string HeshNum { get; set; }
        public string HeshName { get; set; }
        public bool Archive { get; set; }
        public DateTime Tstamp { get; set; }
    }
}

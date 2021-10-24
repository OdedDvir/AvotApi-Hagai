using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblManot
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public DateTime? ManaDate { get; set; }
        public short? ManaId { get; set; }
        public bool? Closed { get; set; }
        public byte? LocationId { get; set; }
    }
}

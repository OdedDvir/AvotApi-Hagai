using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFollowGroup
    {
        public int Id { get; set; }
        public string Subject1 { get; set; }
        public DateTime? Date1 { get; set; }
        public int? TypeForm { get; set; }
        public int? LocationId { get; set; }
    }
}

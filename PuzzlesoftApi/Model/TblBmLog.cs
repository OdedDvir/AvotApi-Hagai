using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBmLog
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public int? NumRead { get; set; }
        public int? NumErr { get; set; }
        public int? UserId { get; set; }
        public int? LocationId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsBdikot
    {
        public int Id { get; set; }
        public int? UserIdcreate { get; set; }
        public int? UserIdlocked { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateLocked { get; set; }
        public int? ToClientId { get; set; }
        public int? BdikaId { get; set; }
        public bool? Locked { get; set; }
        public short? BdikaCategory { get; set; }
    }
}

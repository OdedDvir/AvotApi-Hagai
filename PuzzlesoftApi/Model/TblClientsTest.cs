using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsTest
    {
        public int Id { get; set; }
        public int? UserIdcreate { get; set; }
        public int? UserIdlocked { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateLocked { get; set; }
        public int? ToClientId { get; set; }
        public int? TestId { get; set; }
        public bool? Locked { get; set; }
    }
}

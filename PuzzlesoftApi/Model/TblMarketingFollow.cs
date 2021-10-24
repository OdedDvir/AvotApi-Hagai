using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMarketingFollow
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public bool? BLocked { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? DateLocked { get; set; }
        public long? UserIdLocked { get; set; }
        public string UserLocked { get; set; }
    }
}

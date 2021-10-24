using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFollowup
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
        public string FollowKey { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public short MishmeretId { get; set; }
    }
}

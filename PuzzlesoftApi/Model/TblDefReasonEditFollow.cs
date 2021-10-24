using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefReasonEditFollow
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? FollowId { get; set; }
        public int? OrderId { get; set; }
        public bool Bdel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FollowInfection
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ParentId { get; set; }
        public int BmId { get; set; }
        public bool? Bdel { get; set; }
        public DateTime? TsTamp { get; set; }
        public int? UserId { get; set; }
    }
}

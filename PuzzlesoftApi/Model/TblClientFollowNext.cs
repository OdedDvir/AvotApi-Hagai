using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFollowNext
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public int FollowId { get; set; }
        public DateTime DateNext { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool Bdel { get; set; }
    }
}

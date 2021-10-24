using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefFollowSubject
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string FollowKey { get; set; }
        public int? OrderId { get; set; }
        public int? FollowId { get; set; }
        public int? Val1 { get; set; }
        public bool? BDel { get; set; }
        public int Kod1 { get; set; }
    }
}

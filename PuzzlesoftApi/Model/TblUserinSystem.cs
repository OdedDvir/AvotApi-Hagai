using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblUserinSystem
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Action1 { get; set; }
        public DateTime? TStamp { get; set; }
        public string ComputerName { get; set; }
        public string ComputerIp { get; set; }
        public string AduserName { get; set; }
        public string Ver { get; set; }
        public bool BVirtual { get; set; }
    }
}

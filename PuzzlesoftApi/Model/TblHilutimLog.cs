using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHilutimLog
    {
        public int Id { get; set; }
        public DateTime Date1 { get; set; }
        public int Count1 { get; set; }
        public short Kind1 { get; set; }
        public int LocationId { get; set; }
        public decimal Sum1 { get; set; }
        public int UserCreateId { get; set; }
        public DateTime TStamp { get; set; }
    }
}

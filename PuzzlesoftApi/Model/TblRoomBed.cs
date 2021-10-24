using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRoomBed
    {
        public int? RoomId { get; set; }
        public short? BedNum { get; set; }
        public short? BedStatus { get; set; }
        public int? TnuahId { get; set; }
        public int? Clientid { get; set; }
        public DateTime? FreeDate { get; set; }
        public DateTime? EnterDate { get; set; }
    }
}

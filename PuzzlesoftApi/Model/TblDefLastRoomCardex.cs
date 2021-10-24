using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefLastRoomCardex
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string RoomId { get; set; }
        public int LocationId { get; set; }
        public bool Bdel { get; set; }
    }
}

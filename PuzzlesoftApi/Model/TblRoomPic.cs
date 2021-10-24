using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRoomPic
    {
        public int Id { get; set; }
        public string PicLocation { get; set; }
        public string PicDesc { get; set; }
        public int? RoomId { get; set; }
    }
}

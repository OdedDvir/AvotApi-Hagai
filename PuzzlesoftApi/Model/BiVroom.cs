using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BiVroom
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string AgafName { get; set; }
        public string MahlakaName { get; set; }
        public short? BedsNum { get; set; }
        public bool? Archive { get; set; }
    }
}

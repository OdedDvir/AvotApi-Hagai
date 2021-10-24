using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTmpRoomEmpty
    {
        public string AgafName { get; set; }
        public string RoomName { get; set; }
        public int? LocationId { get; set; }
        public int? Id { get; set; }
        public string Mahlaka { get; set; }
        public string DateLeave { get; set; }
        public string DateEnter { get; set; }
        public short? BedsInUse { get; set; }
        public short? Teken { get; set; }
        public string RoomClass { get; set; }
        public DateTime? DateAsk { get; set; }
        public string Comments { get; set; }
    }
}

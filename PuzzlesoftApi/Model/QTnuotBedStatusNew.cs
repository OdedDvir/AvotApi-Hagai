using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QTnuotBedStatusNew
    {
        public int Id { get; set; }
        public int? TnuahId { get; set; }
        public int? RoomId { get; set; }
        public short? BedNum { get; set; }
        public int? RoomIdold { get; set; }
        public short? BedNumOld { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? ClientId { get; set; }
        public bool? SingleInRoom { get; set; }
    }
}

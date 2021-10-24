using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QRoomsWithLocation
    {
        public int Id { get; set; }
        public int? AgafId { get; set; }
        public string RoomName { get; set; }
        public short? BedsNum { get; set; }
        public string Comments { get; set; }
        public string RoomDefs { get; set; }
        public short? NObj { get; set; }
        public string RoomPrice { get; set; }
        public string RoomSize { get; set; }
        public string RoomNum { get; set; }
        public string RoomClass { get; set; }
        public bool? AirCond { get; set; }
        public short? MahlakaId { get; set; }
        public short? Teken { get; set; }
        public bool? Archive { get; set; }
        public int OwnerId { get; set; }
        public int MaslulId { get; set; }
        public string OwnerDetails { get; set; }
        public short? Locationid { get; set; }
    }
}

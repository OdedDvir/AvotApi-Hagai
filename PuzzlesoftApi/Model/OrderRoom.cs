using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class OrderRoom
    {
        public int? OrderNum { get; set; }
        public int? RoomNum { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public int? Babies { get; set; }
        public int? DaysNum { get; set; }
        public DateTime? ArriveDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? ServiceCode { get; set; }
        public int? RoomKindCode { get; set; }
        public int? AgafId { get; set; }
        public string DoorNum { get; set; }
        public decimal? Price { get; set; }
        public string ClientId { get; set; }
    }
}

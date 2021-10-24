using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblListPriceRoomDetail
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public int? RoomId { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal PriceDolar { get; set; }
        public decimal BasicPrice { get; set; }
        public decimal Ahzaka { get; set; }
        public int? NumOfRooms { get; set; }
    }
}

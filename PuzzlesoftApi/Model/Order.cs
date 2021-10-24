using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Order
    {
        public int? OrderNum { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? NumOfRooms { get; set; }
        public string User { get; set; }
    }
}

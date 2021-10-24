using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Discount
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? OptDiscount { get; set; }
        public string Details { get; set; }
    }
}

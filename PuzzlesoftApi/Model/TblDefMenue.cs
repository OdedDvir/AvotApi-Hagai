using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefMenue
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public int? LunchId { get; set; }
        public int? ParitId { get; set; }
        public float? Quantity { get; set; }
    }
}

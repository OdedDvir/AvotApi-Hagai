using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTestMarkDescription
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
        public int? SPoint { get; set; }
        public int? EPoint { get; set; }
        public string Description { get; set; }
    }
}

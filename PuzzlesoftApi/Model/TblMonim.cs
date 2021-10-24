using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMonim
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public double? LastRead { get; set; }
        public short NType { get; set; }
    }
}

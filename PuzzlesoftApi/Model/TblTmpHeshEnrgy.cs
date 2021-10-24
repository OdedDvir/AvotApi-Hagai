using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTmpHeshEnrgy
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public double NewRead { get; set; }
        public double PrevRead { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public short NType { get; set; }
    }
}

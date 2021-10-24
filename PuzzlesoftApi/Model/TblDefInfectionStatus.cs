using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefInfectionStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Bdel { get; set; }
        public bool? NotChoose { get; set; }
    }
}

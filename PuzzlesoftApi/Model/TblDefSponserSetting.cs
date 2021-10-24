using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefSponserSetting
    {
        public int Id { get; set; }
        public int? SponserId { get; set; }
        public bool? BNotIncLastDay { get; set; }
    }
}

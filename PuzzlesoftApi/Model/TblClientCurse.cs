using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientCurse
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? ThemeId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Description { get; set; }
    }
}

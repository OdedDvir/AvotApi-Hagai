using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientMedSign
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? ThemeId { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

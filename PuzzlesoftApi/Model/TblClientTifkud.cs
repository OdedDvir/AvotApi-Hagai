using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTifkud
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? ThemeId { get; set; }
        public int? DescriptionId { get; set; }
        public string Comments { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

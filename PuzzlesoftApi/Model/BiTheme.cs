using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BiTheme
    {
        public int Id { get; set; }
        public int? PotentialPlaceMugan { get; set; }
        public int? PotencialPlaceSiudit { get; set; }
        public int? FullPlaceMugan { get; set; }
        public int? FullPlaceSiudit { get; set; }
        public string Theme { get; set; }
        public string Key1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConstMabarControl
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public int ThemeId { get; set; }
        public int? MaxScore { get; set; }
    }
}

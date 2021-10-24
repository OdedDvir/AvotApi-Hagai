using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefHarshahModule
    {
        public string Item { get; set; }
        public short? Id { get; set; }
        public short? AppId { get; set; }
        public string ThemeKey { get; set; }
        public bool? InToolbar { get; set; }
        public bool? InHarshah { get; set; }
        public string Icon { get; set; }
        public string HarshahKey { get; set; }
        public bool? InMenu { get; set; }
        public string ViewKind { get; set; }
        public string ToolTip { get; set; }
        public int Iid { get; set; }
    }
}

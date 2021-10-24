using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblToolbarButton
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Caption { get; set; }
        public string Key { get; set; }
        public string ToolTip { get; set; }
        public bool? BDefault { get; set; }
        public string ImageFile { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDynamicReport
    {
        public string SFields { get; set; }
        public string SCaptions { get; set; }
        public string SSizes { get; set; }
        public string SOrder1 { get; set; }
        public string SOrder2 { get; set; }
        public string SGroup { get; set; }
        public string SConditions { get; set; }
        public int? NType { get; set; }
        public string SName { get; set; }
        public bool? BConst { get; set; }
        public int Id { get; set; }
        public string SConditionsCap { get; set; }
    }
}

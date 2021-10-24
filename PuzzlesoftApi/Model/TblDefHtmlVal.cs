using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefHtmlVal
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string ClsName { get; set; }
        public short? OParent { get; set; }
        public bool? BDef { get; set; }
        public int? OrdId { get; set; }
        public int? TypFormId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefItemFuncGuide
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int OrderId { get; set; }
        public string Key1 { get; set; }
        public bool Bdel { get; set; }
    }
}

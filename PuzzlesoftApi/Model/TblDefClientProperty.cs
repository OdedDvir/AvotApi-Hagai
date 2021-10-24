using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefClientProperty
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public short? MainId { get; set; }
        public string Key1 { get; set; }
        public string ParentKey { get; set; }
        public bool? Archive { get; set; }
    }
}

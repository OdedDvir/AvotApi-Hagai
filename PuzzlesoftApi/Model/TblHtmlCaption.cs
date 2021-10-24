using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHtmlCaption
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public int? OrderId { get; set; }
        public int FormId { get; set; }
        public string Key1 { get; set; }
        public string KeyComment { get; set; }
        public bool Bdel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefTavitFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileCap { get; set; }
        public int NCols { get; set; }
        public int NRows { get; set; }
        public string Src1 { get; set; }
        public string HtmlCss { get; set; }
        public bool NextRec { get; set; }
        public string Key1 { get; set; }
        public int? Orderid { get; set; }
        public string NColsName { get; set; }
    }
}

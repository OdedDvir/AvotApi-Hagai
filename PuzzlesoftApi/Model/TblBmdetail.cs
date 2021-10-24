using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBmdetail
    {
        public int Id { get; set; }
        public int? Bmid { get; set; }
        public float? Min1 { get; set; }
        public float? Max1 { get; set; }
        public string SYm { get; set; }
        public string Caption1 { get; set; }
        public string Class1 { get; set; }
    }
}

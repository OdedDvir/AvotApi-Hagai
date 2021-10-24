using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTestDetail
    {
        public int Id { get; set; }
        public string Value1 { get; set; }
        public int? NLine { get; set; }
        public int? TestId { get; set; }
        public int? NType { get; set; }
    }
}

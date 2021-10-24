using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBdikaDetail
    {
        public int Id { get; set; }
        public int? BdikaId { get; set; }
        public bool? BNumric { get; set; }
        public int? Min1 { get; set; }
        public int? Max1 { get; set; }
    }
}

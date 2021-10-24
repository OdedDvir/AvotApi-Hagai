using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientBdikaDetail
    {
        public int Id { get; set; }
        public int? ClientBdikaId { get; set; }
        public bool? IsNotCorrect { get; set; }
        public string Value1 { get; set; }
        public int? BdikaDetailId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConstChargeRange
    {
        public int Id { get; set; }
        public int? ConstChargeId { get; set; }
        public int? Min1 { get; set; }
        public int? Max1 { get; set; }
        public int? Price1 { get; set; }
    }
}

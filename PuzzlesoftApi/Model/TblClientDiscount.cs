using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientDiscount
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Kod1 { get; set; }
        public short? NType { get; set; }
        public float? Val1 { get; set; }
        public string Memo1 { get; set; }
    }
}

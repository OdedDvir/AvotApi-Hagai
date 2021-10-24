using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMahsanim
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? NLevel { get; set; }
        public short? LocationId { get; set; }
        public short? NKind { get; set; }
    }
}

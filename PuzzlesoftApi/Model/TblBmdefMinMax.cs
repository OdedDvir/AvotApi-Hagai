using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBmdefMinMax
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public short? NOrder { get; set; }
        public string DefYm { get; set; }
        public string DefMin { get; set; }
        public string DefMax { get; set; }
        public int? NKupa { get; set; }
        public int? MiunId { get; set; }
    }
}

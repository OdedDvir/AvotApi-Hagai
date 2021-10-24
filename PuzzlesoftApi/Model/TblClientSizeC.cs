using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientSizeC
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? Item { get; set; }
        public string Size { get; set; }
    }
}

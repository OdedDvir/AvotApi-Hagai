using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRentgenPrice
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string MktSapak { get; set; }
        public string MktHospital { get; set; }
        public decimal? Price { get; set; }
        public bool? Bdel { get; set; }
    }
}

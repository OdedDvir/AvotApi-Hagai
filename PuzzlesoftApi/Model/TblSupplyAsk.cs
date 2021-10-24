using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblSupplyAsk
    {
        public int Id { get; set; }
        public int? HeshItemId { get; set; }
        public int? DocId { get; set; }
        public double? SupplyAsk { get; set; }
        public double? SupplyBalance { get; set; }
        public int? UserCreateId { get; set; }
        public bool? BDel { get; set; }
    }
}

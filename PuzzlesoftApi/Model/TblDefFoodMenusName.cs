using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefFoodMenusName
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? ClientId { get; set; }
        public int? LocationId { get; set; }
    }
}

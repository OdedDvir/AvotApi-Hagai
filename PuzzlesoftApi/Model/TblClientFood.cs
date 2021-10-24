using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFood
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public int? LunchId { get; set; }
        public DateTime? Date1 { get; set; }
        public int? FoodId { get; set; }
        public int? EatId { get; set; }
        public int? SpoonSum { get; set; }
        public bool? BDel { get; set; }
    }
}

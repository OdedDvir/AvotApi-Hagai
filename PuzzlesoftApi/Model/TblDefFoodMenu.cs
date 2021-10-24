using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefFoodMenu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string FoodInclude { get; set; }
        public string LunchId { get; set; }
        public int? MenuId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFoodMenu
    {
        public int Id { get; set; }
        public int? LunchId { get; set; }
        public string FoodInclude { get; set; }
        public int? Clientid { get; set; }
        public string MenuName { get; set; }
    }
}

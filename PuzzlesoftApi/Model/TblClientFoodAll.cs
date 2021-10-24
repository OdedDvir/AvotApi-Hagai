using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFoodAll
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public DateTime? Date1 { get; set; }
        public string Lunch { get; set; }
        public string FoodAll { get; set; }
        public double? KaloryAll { get; set; }
        public double? HelbonAll { get; set; }
        public double? PahmimotAll { get; set; }
        public bool? BDel { get; set; }
        public string FoodComment { get; set; }
    }
}

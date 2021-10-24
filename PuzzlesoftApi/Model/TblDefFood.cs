using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefFood
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public float? Kalory { get; set; }
        public float? Helbon { get; set; }
        public float? Pahmimot { get; set; }
        public int? Portion { get; set; }
        public string Unit { get; set; }
        public bool? BAddings { get; set; }
        public string Quantity { get; set; }
        public bool? BChoose { get; set; }
        public bool? BDel { get; set; }
    }
}

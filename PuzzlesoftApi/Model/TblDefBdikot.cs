using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefBdikot
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Key1 { get; set; }
        public string Ym { get; set; }
        public string DinkoKod { get; set; }
        public bool Bdel { get; set; }
        public string ItemDetails { get; set; }
        public int? MainId { get; set; }
        public int Type { get; set; }
        public int? Ordid { get; set; }
    }
}

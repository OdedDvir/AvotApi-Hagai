using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientDietAfterIshpuz
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string IshpuzReason { get; set; }
        public float? WeightAfterIshpuz { get; set; }
        public string WeightNormal { get; set; }
        public float? WeightChangeLastMonth { get; set; }
        public string BdikotHelbon { get; set; }
        public string BdikotAlbomin { get; set; }
        public string BdikotHemoglobin { get; set; }
        public string MirkamMazon { get; set; }
        public string EatingFormat { get; set; }
        public string KaloriesSum { get; set; }
        public string HelbonSum { get; set; }
        public string Target { get; set; }
        public string Tipul { get; set; }
        public DateTime Date1 { get; set; }
        public bool? BDel { get; set; }
    }
}

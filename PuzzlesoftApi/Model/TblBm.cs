using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBm
    {
        public int Id { get; set; }
        public string Name1 { get; set; }
        public int? MiunId { get; set; }
        public bool Archive { get; set; }
        public string DefYm { get; set; }
        public float? DefMin { get; set; }
        public float? DefMax { get; set; }
        public string Key1 { get; set; }
        public int? TempId { get; set; }
        public string TempVal { get; set; }
        public string KupaKey1 { get; set; }
        public string KupaKey2 { get; set; }
        public string KupaKey3 { get; set; }
        public string KupaKey4 { get; set; }
        public string KupaKey5 { get; set; }
        public string KupaBc1 { get; set; }
        public string KupaBc2 { get; set; }
        public string KupaBc3 { get; set; }
        public string KupaBc4 { get; set; }
        public string KupaBc5 { get; set; }
        public short? NOrder { get; set; }
        public string UniqMacabiId { get; set; }
        public string UniqClalitId { get; set; }
        public bool DietBm { get; set; }
        public bool GermM { get; set; }
        public int OrderId { get; set; }
        public string SeegnalCode { get; set; }
        public string SeegnalStatusBm { get; set; }
    }
}

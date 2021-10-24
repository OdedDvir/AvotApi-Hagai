using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormKey
    {
        public string FormKey { get; set; }
        public string Key1 { get; set; }
        public string Cap1 { get; set; }
        public bool? Archive { get; set; }
        public short? OrderId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormsTemplatedToDell
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public int? UserIdcreate { get; set; }
        public string SType { get; set; }
        public bool Locked { get; set; }
        public bool Archive { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public double? CorrectMin { get; set; }
        public double? CorrectMax { get; set; }
        public string HtmlSource { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string FormKey { get; set; }
    }
}

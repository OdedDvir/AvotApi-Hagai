using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAvhanot
    {
        public string KodY { get; set; }
        public string Kod { get; set; }
        public double? AvhanaKind { get; set; }
        public string Item { get; set; }
        public string InBalev { get; set; }
        public int Id { get; set; }
        public bool BSpec { get; set; }
        public string ShortKey { get; set; }
        public int? MiunId { get; set; }
        public DateTime? TStamp { get; set; }
        public int? Userid { get; set; }
        public bool BShortList { get; set; }
        public bool Archive { get; set; }
        public string SeegnalCode { get; set; }
        public string Icdkind { get; set; }
    }
}

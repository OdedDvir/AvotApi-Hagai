using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFilter
    {
        public int Id { get; set; }
        public string Name1 { get; set; }
        public string Typ1 { get; set; }
        public string Filed1 { get; set; }
        public string ListAllowOption { get; set; }
        public string TblDefList { get; set; }
        public string FieldList { get; set; }
        public int? OrderId { get; set; }
    }
}

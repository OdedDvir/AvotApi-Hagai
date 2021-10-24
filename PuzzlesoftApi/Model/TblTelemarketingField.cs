using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTelemarketingField
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Key { get; set; }
        public bool? Archive { get; set; }
        public int? OrderId { get; set; }
    }
}

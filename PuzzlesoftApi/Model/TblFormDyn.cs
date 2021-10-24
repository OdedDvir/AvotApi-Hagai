using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormDyn
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string FormTyp { get; set; }
        public bool? Locked { get; set; }
    }
}

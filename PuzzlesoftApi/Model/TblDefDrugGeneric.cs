using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefDrugGeneric
    {
        public int Id { get; set; }
        public string GenericName { get; set; }
        public bool Archive { get; set; }
        public string SeegnalCode { get; set; }
    }
}

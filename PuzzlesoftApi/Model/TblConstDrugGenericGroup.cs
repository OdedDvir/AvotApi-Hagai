using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConstDrugGenericGroup
    {
        public int Id { get; set; }
        public string GenericGroupName { get; set; }
        public bool Archive { get; set; }
        public string SeegnalCode { get; set; }
    }
}

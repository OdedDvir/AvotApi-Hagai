using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConstDrugTakeKind
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string SeegnalCode { get; set; }
        public string SeegnalRouteName { get; set; }
        public bool Binjections { get; set; }
        public bool Boral { get; set; }
    }
}

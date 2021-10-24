using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConstDrugInteraction
    {
        public string Generic1Desc { get; set; }
        public string Generic2Desc { get; set; }
        public short? InteractionKind { get; set; }
        public string InteractionMsg { get; set; }
        public short? InteractionMsgOrder { get; set; }
    }
}

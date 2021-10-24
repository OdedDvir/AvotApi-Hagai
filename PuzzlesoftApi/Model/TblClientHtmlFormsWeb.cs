using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHtmlFormsWeb
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string FormKey { get; set; }
        public string Header1 { get; set; }
        public bool BDel { get; set; }
        public bool BLocked { get; set; }
        public bool BAutoLocked { get; set; }
        public int UserIdCreate { get; set; }
        public int UserIdUpdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime TStampUpdate { get; set; }
        public int UserIdLocked { get; set; }
        public DateTime? TStampLocked { get; set; }
        public int TorId { get; set; }
        public bool BdoSave { get; set; }
        public int? Point { get; set; }
        public int BNeedRefresh { get; set; }
    }
}

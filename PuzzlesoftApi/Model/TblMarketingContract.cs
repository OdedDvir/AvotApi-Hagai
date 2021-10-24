using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMarketingContract
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ContractName { get; set; }
        public int SuggestId { get; set; }
        public DateTime TStamp { get; set; }
        public string UserName { get; set; }
    }
}

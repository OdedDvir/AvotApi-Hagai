using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TelemarketingDoc
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public string ContractName { get; set; }
        public int SuggestId { get; set; }
        public DateTime TStamp { get; set; }
        public string Username { get; set; }
        public int? UserId { get; set; }
        public string Type { get; set; }
    }
}

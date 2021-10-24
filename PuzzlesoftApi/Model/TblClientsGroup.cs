using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsGroup
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? LocationId { get; set; }
        public string ClientList { get; set; }
        public long? UserId { get; set; }
        public DateTime? TsTamp { get; set; }
        public bool? BDel { get; set; }
    }
}

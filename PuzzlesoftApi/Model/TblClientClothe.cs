using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientClothe
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Action { get; set; }
        public int? Item { get; set; }
        public int? Quantity { get; set; }
        public string Size { get; set; }
        public DateTime? TStamp { get; set; }
        public int? UserId { get; set; }
        public string UserCreate { get; set; }
        public bool? BDel { get; set; }
    }
}

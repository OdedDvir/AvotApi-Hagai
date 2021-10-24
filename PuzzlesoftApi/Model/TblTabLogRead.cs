using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTabLogRead
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Memo1 { get; set; }
    }
}

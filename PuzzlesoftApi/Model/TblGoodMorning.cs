using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblGoodMorning
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string NameView { get; set; }
        public bool? Chk1 { get; set; }
        public bool? Chk2 { get; set; }
        public string SetChk1 { get; set; }
        public string SetChk2 { get; set; }
        public DateTime? Date1 { get; set; }
        public bool? BLocked { get; set; }
        public string Mem1 { get; set; }
        public string Mem2 { get; set; }
        public DateTime? Tstamp { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QEventList
    {
        public int Id { get; set; }
        public bool? Bdel { get; set; }
        public string Nameview { get; set; }
        public string Roomname { get; set; }
        public string StatusForm { get; set; }
        public bool? Locked { get; set; }
        public string Asm { get; set; }
        public string TypeEvent1 { get; set; }
        public int TypeEventId1 { get; set; }
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public string TypeEvent2 { get; set; }
        public string TypeEventCap { get; set; }
        public DateTime? Datecreated { get; set; }
        public short? Locationid { get; set; }
    }
}

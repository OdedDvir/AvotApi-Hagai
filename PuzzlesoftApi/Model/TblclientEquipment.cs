using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblclientEquipment
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public int FormId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Memo { get; set; }
        public DateTime? Tstamp { get; set; }
        public int? Userid { get; set; }
        public string Usercreate { get; set; }
        public bool Bdel { get; set; }
    }
}

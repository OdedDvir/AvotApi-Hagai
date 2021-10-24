using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAgafItem
    {
        public int Id { get; set; }
        public int? AgafId { get; set; }
        public int? RoomId { get; set; }
        public int? ParitId { get; set; }
        public string Memo1 { get; set; }
        public string ItemLink { get; set; }
        public string ParitKod { get; set; }
        public int? ConstRoom { get; set; }
        public string BarCode1 { get; set; }
        public bool? BActive { get; set; }
        public bool? BDel { get; set; }
        public int? Clientid { get; set; }
    }
}

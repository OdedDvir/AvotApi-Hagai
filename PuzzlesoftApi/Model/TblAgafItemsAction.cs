using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAgafItemsAction
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string ParitKod { get; set; }
        public int? RoomIdD { get; set; }
        public int? RoomIdS { get; set; }
        public byte? NTyp { get; set; }
        public int? UserCreate { get; set; }
        public string Memo1 { get; set; }
        public int? RelatedId { get; set; }
    }
}

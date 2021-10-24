using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblSidurWorkerRoom
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int RoomId { get; set; }
        public string Action1 { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Days { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public int UserId { get; set; }
        public DateTime TStamp { get; set; }
        public bool? BDel { get; set; }
        public int? DayarId { get; set; }
    }
}

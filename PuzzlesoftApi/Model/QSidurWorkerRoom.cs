using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QSidurWorkerRoom
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string WorkerIdcard { get; set; }
        public string Action1 { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Days { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public bool? BDel { get; set; }
        public string DayarName { get; set; }
        public string DayarLastStatus { get; set; }
        public short? LocationId { get; set; }
    }
}

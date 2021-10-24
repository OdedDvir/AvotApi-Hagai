using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateBill { get; set; }
        public string NumCall { get; set; }
        public string Extension { get; set; }
        public DateTime DateCall { get; set; }
        public string TimeCall { get; set; }
        public string RingTimeCall { get; set; }
        public double SumCost { get; set; }
        public string KindCall { get; set; }
        public string NumCalled { get; set; }
        public string SapakCall { get; set; }
        public bool BCharged { get; set; }
        public int GroupId { get; set; }
        public int KindCallId { get; set; }
        public double TimeCallMinutes { get; set; }
        public double SumCostNoMaham { get; set; }
        public string RoomId { get; set; }
        public bool BFlag { get; set; }
    }
}

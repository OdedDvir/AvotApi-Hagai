using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMelayPrRefuee
    {
        public int Id { get; set; }
        public string ParitKod { get; set; }
        public string State1 { get; set; }
        public int? AgafId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? DateLast { get; set; }
        public DateTime? DateFuture { get; set; }
        public string Yazran { get; set; }
        public string ParitNum { get; set; }
        public string TakeBy { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? Bdel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHilutim
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string RoomName { get; set; }
        public decimal HilutSum { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? Date3 { get; set; }
        public DateTime? DateStop { get; set; }
        public short? Kind1 { get; set; }
        public decimal HilutYear { get; set; }
        public decimal HilutRatio { get; set; }
        public decimal MadadBasic { get; set; }
        public decimal DolarBasic { get; set; }
        public int UserCreateId { get; set; }
        public DateTime TStamp { get; set; }
        public int OrdId { get; set; }
        public bool BNoAutoApproval { get; set; }
        public string ApprovalMemo { get; set; }
        public DateTime? DateRealHilut { get; set; }
        public bool BNoveToOther { get; set; }
        public int HilutMoveId { get; set; }
        public decimal HilutMoveDolar { get; set; }
        public bool BN { get; set; }
        public int NId { get; set; }
        public int BNn { get; set; }
        public int PikadonTypeHazmzda { get; set; }
        public double RibitMonthPer { get; set; }
        public double RibitMonthPerDelay { get; set; }
        public int LateDays { get; set; }
        public bool HesKemForPikadon { get; set; }
    }
}

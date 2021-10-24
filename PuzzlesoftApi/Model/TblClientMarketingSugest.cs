using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientMarketingSugest
    {
        public int Id { get; set; }
        public int? AgafId { get; set; }
        public int? RoomId { get; set; }
        public int? DiurKindId { get; set; }
        public string PriceEnter { get; set; }
        public string PriceStay { get; set; }
        public string PriceBack { get; set; }
        public int? ClientId { get; set; }
        public string HilutMon { get; set; }
        public string HilutMax { get; set; }
        public string PriceStaySiudi { get; set; }
        public DateTime? DateNeedEnter { get; set; }
        public DateTime? DateAsk { get; set; }
        public short? DiminutionEnterPer { get; set; }
        public short? DiminutionStayPer { get; set; }
        public int? DiminutionEnterReasonId { get; set; }
        public int? DiminutionStayReasonId { get; set; }
        public bool? BVisitor { get; set; }
        public string PriceStayTashush { get; set; }
        public string PriceSiudiZmani { get; set; }
        public short? EnterMaslul { get; set; }
        public DateTime? DateVisit1 { get; set; }
        public int? AgafIdV { get; set; }
        public int? RoomIdV { get; set; }
        public DateTime? DateVisit2 { get; set; }
        public short? TifkudStatusId { get; set; }
        public short? SugestId { get; set; }
        public string PriceTashushOut { get; set; }
        public string MaslulService { get; set; }
        public string EnterPriceInWords { get; set; }
        public string MadadMonth { get; set; }
        public float? MadadPoints { get; set; }
        public string MadadPointsInWords { get; set; }
        public bool? BRoomInUse { get; set; }
    }
}

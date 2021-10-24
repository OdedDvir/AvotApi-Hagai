using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QMarketingSugest
    {
        public int? Id { get; set; }
        public int? RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomClass { get; set; }
        public string RoomSize { get; set; }
        public int? RoomNum { get; set; }
        public string Mahlaka { get; set; }
        public string AgafName { get; set; }
        public string PriceEnter { get; set; }
        public string EnterPriceInWords { get; set; }
        public string PriceStay { get; set; }
        public short? SugestId { get; set; }
        public string PriceBack { get; set; }
        public string NameView { get; set; }
        public string PriceStaySiudi { get; set; }
        public string NeedToEnterDate { get; set; }
        public string AskToEnterDate { get; set; }
        public string PriceStayTashush { get; set; }
        public string PriceTashushOut { get; set; }
        public int? ClientId { get; set; }
        public string RelatedNameView { get; set; }
        public string RelatedIdcard { get; set; }
        public string RelatedStreet { get; set; }
        public string RelatedCity { get; set; }
        public string Idcard { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string DateAsk { get; set; }
        public string CompanyAddress { get; set; }
        public string Kupa { get; set; }
        public string EnterMaslul { get; set; }
        public string MaslulService { get; set; }
        public string HilutMon { get; set; }
        public float? HilutYears { get; set; }
        public string HilutMax { get; set; }
        public decimal? HilutMaxPerMon { get; set; }
        public string MadadMonth { get; set; }
        public float? MadadPoints { get; set; }
        public string MadadPointsInWords { get; set; }
        public int? DiurKindId { get; set; }
        public string ListPriceFb { get; set; }
        public string ListPriceHb { get; set; }
        public string ListPriceBo { get; set; }
    }
}

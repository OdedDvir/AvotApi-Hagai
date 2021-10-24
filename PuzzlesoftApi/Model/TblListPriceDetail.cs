using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblListPriceDetail
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public string ParitKod { get; set; }
        public decimal? ParitPrice { get; set; }
        public string MakatSpak { get; set; }
        public bool? BPriceConst { get; set; }
        public string PriceCoin { get; set; }
        public short? CoinId { get; set; }
        public int? NType { get; set; }
        public bool? BChargeByStay { get; set; }
        public bool? BChargeByTofes17 { get; set; }
        public string MakatSapak { get; set; }
        public decimal? Price2 { get; set; }
        public string ParitKodOld { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
    }
}

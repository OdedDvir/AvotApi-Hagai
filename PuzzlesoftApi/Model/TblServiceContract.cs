using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblServiceContract
    {
        public int Id { get; set; }
        public int? SapakId { get; set; }
        public string ServiceKod { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public decimal? ServicePrice { get; set; }
        public string Coin { get; set; }
        public int? ResponsibleId { get; set; }
        public string Comments { get; set; }
        public byte? HatsmadaId { get; set; }
        public int? ServiceId { get; set; }
        public short? LocationId { get; set; }
        public bool? BDel { get; set; }
        public string DocNameView { get; set; }
        public string DocName { get; set; }
    }
}

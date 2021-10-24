using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QServiceContract
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
        public string SapakName { get; set; }
        public string ServiceName { get; set; }
        public short? SapakLocation { get; set; }
        public string ServicePrice1 { get; set; }
        public string SapakDetails { get; set; }
        public short? ContractLocation { get; set; }
        public bool? BDel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBiocomCharge
    {
        public int ClientId { get; set; }
        public string ServiceKod { get; set; }
        public string ServiceName { get; set; }
        public DateTime? Date1 { get; set; }
        public short BDay { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int BiocomKod { get; set; }
        public string Idcard { get; set; }
        public int? MiunId { get; set; }
        public int Id { get; set; }
        public int MainId { get; set; }
        public int? MainKind { get; set; }
        public string Comments { get; set; }
        public bool? BCharged { get; set; }
        public bool? Bdel { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsSeegnalRespone
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public string SeegnalUrl { get; set; }
        public int? IndicatorStatus { get; set; }
        public DateTime Tstampcreate { get; set; }
        public int AlertsCount { get; set; }
        public int BypassCount { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientYediah
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Yediah { get; set; }
        public string Comments { get; set; }
        public DateTime? Date1 { get; set; }
        public string Description { get; set; }
    }
}

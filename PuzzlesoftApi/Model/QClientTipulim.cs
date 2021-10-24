using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientTipulim
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Comments { get; set; }
        public string Drug { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? Times { get; set; }
        public string Tipul { get; set; }
        public bool? TipulIn { get; set; }
        public string Place { get; set; }
        public string Reason { get; set; }
    }
}

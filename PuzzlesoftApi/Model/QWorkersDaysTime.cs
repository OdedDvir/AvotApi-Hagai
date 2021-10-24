using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QWorkersDaysTime
    {
        public int? WorkerId { get; set; }
        public string Time1From { get; set; }
        public string Time1To { get; set; }
        public short? MahlakaId { get; set; }
        public string Mahlaka { get; set; }
        public int Id { get; set; }
        public short? MishmeretId { get; set; }
        public string Mishmeret { get; set; }
    }
}

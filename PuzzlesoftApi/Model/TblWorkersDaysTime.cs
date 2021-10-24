using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblWorkersDaysTime
    {
        public int? WorkerId { get; set; }
        public string Time1From { get; set; }
        public string Time1To { get; set; }
        public string Time2From { get; set; }
        public string Time2To { get; set; }
        public int? NDay { get; set; }
        public short? MahlakaId { get; set; }
        public int Id { get; set; }
        public short? MishmeretId { get; set; }
    }
}

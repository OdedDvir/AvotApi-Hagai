using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblclientTakingWC
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public int? QuantityMorning { get; set; }
        public int? QuantityNight { get; set; }
        public bool? Control { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public long? FormId { get; set; }
        public bool? BDel { get; set; }
        public DateTime? TsCreateDate { get; set; }
    }
}

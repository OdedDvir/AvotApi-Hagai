using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblYeshivatTzevetLock
    {
        public int Id { get; set; }
        public int? ToClientId { get; set; }
        public int? YeshivaId { get; set; }
        public int? UserLock { get; set; }
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public string UserLogin { get; set; }
    }
}

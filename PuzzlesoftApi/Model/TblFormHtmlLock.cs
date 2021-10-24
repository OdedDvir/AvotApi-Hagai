using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormHtmlLock
    {
        public int Id { get; set; }
        public int? ToClientId { get; set; }
        public int? FormTypeId { get; set; }
        public int? UserLock { get; set; }
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public int? FormTypeId2 { get; set; }
    }
}

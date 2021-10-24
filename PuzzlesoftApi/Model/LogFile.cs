using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class LogFile
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public int? UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBmPass
    {
        public int Id { get; set; }
        public int NKupa { get; set; }
        public string AvotKey { get; set; }
        public string KupaKey { get; set; }
        public int UserId { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

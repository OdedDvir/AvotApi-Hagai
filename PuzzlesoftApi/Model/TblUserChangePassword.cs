using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblUserChangePassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public DateTime Tstamp { get; set; }
        public bool? ByUser { get; set; }
    }
}

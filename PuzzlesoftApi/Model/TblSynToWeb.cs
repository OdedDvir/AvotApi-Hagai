using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblSynToWeb
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
    }
}

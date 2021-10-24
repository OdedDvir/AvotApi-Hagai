using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblConnection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServerIp { get; set; }
        public string ServerUsername { get; set; }
        public string ServerPassword { get; set; }
        public string Dbname { get; set; }
    }
}

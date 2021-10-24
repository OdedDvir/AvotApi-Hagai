using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMasavTempTable
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public int UserId { get; set; }
        public decimal Sum1 { get; set; }
        public string Gid { get; set; }
    }
}

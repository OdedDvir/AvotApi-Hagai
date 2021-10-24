using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblLogInfectionsClosed
    {
        public int Id { get; set; }
        public int? InfectId { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime? Tstamp { get; set; }
        public int? Userid { get; set; }
        public string Username { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTyingActual
    {
        public int Id { get; set; }
        public int TyingId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Duration { get; set; }
        public string Comment { get; set; }
        public int? UserIdCreate { get; set; }
    }
}

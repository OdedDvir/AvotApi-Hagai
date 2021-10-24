using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTyingControlCommittee
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TyingId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Rep { get; set; }
        public int? TypeForm { get; set; }
        public int? UserIdCreate { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRefueeMainForm
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public DateTime Date1 { get; set; }
        public bool? Locked { get; set; }
        public int? RekaId { get; set; }
        public int? SikumId { get; set; }
        public int? SkiraId { get; set; }
        public int? Skira2Id { get; set; }
        public string ListLocked { get; set; }
        public string FormKind { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientCurrentStatus
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Item { get; set; }
        public short? ThemeId { get; set; }
        public short? RecStatus { get; set; }
        public DateTime? Date1 { get; set; }
        public int? UserId { get; set; }
    }
}

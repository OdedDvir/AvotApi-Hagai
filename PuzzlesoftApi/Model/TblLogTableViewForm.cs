using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblLogTableViewForm
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? ClientId { get; set; }
        public string Key1 { get; set; }
        public long? ClientFormId { get; set; }
        public DateTime? Tstamp { get; set; }
    }
}

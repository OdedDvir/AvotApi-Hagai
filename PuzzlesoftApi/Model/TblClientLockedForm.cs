using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientLockedForm
    {
        public int Id { get; set; }
        public int? ClientFormId { get; set; }
        public int? ClientId { get; set; }
        public string HtmlSource { get; set; }
    }
}

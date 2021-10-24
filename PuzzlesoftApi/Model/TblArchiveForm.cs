using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblArchiveForm
    {
        public int Id { get; set; }
        public string HtmlSource { get; set; }
        public DateTime? Date1 { get; set; }
        public string Name1 { get; set; }
        public string Key1 { get; set; }
    }
}

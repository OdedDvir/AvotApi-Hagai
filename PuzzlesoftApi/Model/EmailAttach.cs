using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class EmailAttach
    {
        public int Id { get; set; }
        public int? EmailId { get; set; }
        public string FileName { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Fax
    {
        public int Id { get; set; }
        public string FaxName { get; set; }
        public string FaxTheme { get; set; }
        public DateTime? FaxDate { get; set; }
        public int? FolderId { get; set; }
        public string FaxFrom { get; set; }
        public string FaxTo { get; set; }
    }
}

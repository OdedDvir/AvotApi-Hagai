using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Court
    {
        public int? FolderId { get; set; }
        public string CourtFolder { get; set; }
        public string ProcessName { get; set; }
        public string Court1 { get; set; }
        public string ProcessKind { get; set; }
        public string CourtCity { get; set; }
        public string Judge { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Time1 { get; set; }
        public string ProcessTheme { get; set; }
        public string Manager1 { get; set; }
        public string Manager2 { get; set; }
        public string Comments { get; set; }
        public int Id { get; set; }
    }
}

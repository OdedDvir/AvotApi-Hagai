using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormBdikaYezumaSiudi
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public string NurseName { get; set; }
        public DateTime? Date1 { get; set; }
        public string TifkudTheme { get; set; }
        public string Details1 { get; set; }
        public bool? Locked { get; set; }
    }
}

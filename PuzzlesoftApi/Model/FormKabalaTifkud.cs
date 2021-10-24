using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormKabalaTifkud
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public string NurseName { get; set; }
        public DateTime? KabalaDate { get; set; }
        public DateTime? Date1 { get; set; }
        public string DayarName { get; set; }
        public string Mahlaka { get; set; }
        public string TifkudFiziTheme { get; set; }
        public string TifkudNafshiTheme { get; set; }
        public string TifkudFiziDetails { get; set; }
        public string TifkudNafshiDetails { get; set; }
        public bool? Locked { get; set; }
        public float? Weight { get; set; }
        public float? Height { get; set; }
    }
}

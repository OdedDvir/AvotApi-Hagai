using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BiAlert
    {
        public int Id { get; set; }
        public int AlertKind { get; set; }
        public DateTime AlertDate { get; set; }
        public string AlertTheme { get; set; }
        public string AlertComment { get; set; }
        public string AlertInform { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string AlertStatus { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BiSurgery
    {
        public int Id { get; set; }
        public DateTime? SurgeryDate { get; set; }
        public string Surgeon { get; set; }
        public string SurgerySpeciality { get; set; }
        public string SurgeryDescription { get; set; }
        public string PatientName { get; set; }
        public string Insurance { get; set; }
        public string Equipment { get; set; }
        public string Pathology { get; set; }
        public string Comments { get; set; }
        public int? SurgeryTime { get; set; }
    }
}

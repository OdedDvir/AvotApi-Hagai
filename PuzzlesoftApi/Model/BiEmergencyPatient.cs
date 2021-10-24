using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BiEmergencyPatient
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public int PatientId { get; set; }
        public decimal Age { get; set; }
        public string Sex { get; set; }
        public string EmergencyStatus { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Urgency { get; set; }
    }
}

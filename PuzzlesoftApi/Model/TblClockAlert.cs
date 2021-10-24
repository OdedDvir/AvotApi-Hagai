using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClockAlert
    {
        public int Id { get; set; }
        public string DeviceNumber { get; set; }
        public string EmergencyType { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

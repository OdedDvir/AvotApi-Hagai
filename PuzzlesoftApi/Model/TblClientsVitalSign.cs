using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsVitalSign
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string PatientId { get; set; }
        public string MonitorId { get; set; }
        public string VitalSignName { get; set; }
        public string Result { get; set; }
        public string ResultDate { get; set; }
        public string Unit { get; set; }
    }
}

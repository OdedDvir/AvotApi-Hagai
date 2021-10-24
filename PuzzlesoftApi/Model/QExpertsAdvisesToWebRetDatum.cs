using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QExpertsAdvisesToWebRetDatum
    {
        public string DoctorName { get; set; }
        public int? Doctorid { get; set; }
        public int? Clientid { get; set; }
        public int Uid { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public DateTime? Date1 { get; set; }
        public string DoctorTel { get; set; }
    }
}

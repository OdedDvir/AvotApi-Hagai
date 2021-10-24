using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class IConnectRequestsEng
    {
        public int Id { get; set; }
        public string Doctor { get; set; }
        public string Area { get; set; }
        public string Clinic { get; set; }
        public string Speciality { get; set; }
        public bool Sla { get; set; }
        public string Request { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
        public string Priority { get; set; }
    }
}

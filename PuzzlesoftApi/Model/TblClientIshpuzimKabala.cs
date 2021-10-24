using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientIshpuzimKabala
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? KabalaId { get; set; }
        public int? UserCreateId { get; set; }
        public string Year1 { get; set; }
        public string Hospital { get; set; }
        public string Department { get; set; }
        public string DoctorName { get; set; }
        public string UserCreate { get; set; }
        public bool? Deleted { get; set; }
        public string Reason { get; set; }
    }
}

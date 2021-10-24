using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormHospitalize
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string MainThemes { get; set; }
        public string TifkudThemes { get; set; }
        public string TifkudDetails { get; set; }
        public string MainDetails { get; set; }
        public string UserName { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

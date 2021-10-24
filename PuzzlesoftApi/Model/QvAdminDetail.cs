using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QvAdminDetail
    {
        public string IdCard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string NameLanguge { get; set; }
        public string Birthday { get; set; }
        public string Height { get; set; }
        public double? Weight { get; set; }
        public string MahlakaName { get; set; }
        public DateTime? Dateenter { get; set; }
        public DateTime? Date1 { get; set; }
        public short? MarketingTifkudStatus { get; set; }
    }
}

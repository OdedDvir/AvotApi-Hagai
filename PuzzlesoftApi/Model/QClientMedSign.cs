using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientMedSign
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string MedSign { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

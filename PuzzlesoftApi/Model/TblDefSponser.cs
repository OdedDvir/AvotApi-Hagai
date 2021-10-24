using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefSponser
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? MacKod { get; set; }
        public bool? Archive { get; set; }
        public int? AmbulanceId { get; set; }
    }
}

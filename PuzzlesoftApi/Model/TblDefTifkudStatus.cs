using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefTifkudStatus
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public bool? Active { get; set; }
        public int? TifkudKindId { get; set; }
        public int? MacKod { get; set; }
        public string MabarKod { get; set; }
        public int MabarType { get; set; }
        public bool Demergency { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPainRequest
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? WorkerKod { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? DateE { get; set; }
        public string TimeS { get; set; }
        public string TimeE { get; set; }
        public string RoomName { get; set; }
        public string ActionKind { get; set; }
    }
}

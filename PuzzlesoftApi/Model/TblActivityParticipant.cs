using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblActivityParticipant
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ActivityId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblWorkerRoom
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public int? RoomId { get; set; }
        public string JobId { get; set; }
        public string FreeDays { get; set; }

        public virtual ClientDetail Client { get; set; }
    }
}

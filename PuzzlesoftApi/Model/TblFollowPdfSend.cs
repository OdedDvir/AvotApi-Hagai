using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFollowPdfSend
    {
        public int Id { get; set; }
        public int FollowId { get; set; }
        public DateTime TStampCreate { get; set; }
    }
}

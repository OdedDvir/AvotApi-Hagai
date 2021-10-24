using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefMedicalGroup
    {
        public short Id { get; set; }
        public string Item { get; set; }
        public int FollowId { get; set; }
        public string Sector { get; set; }
    }
}

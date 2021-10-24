using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDiaryPharmV1Interaction
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Interaction { get; set; }
        public string InteractionId { get; set; }
        public string Essence { get; set; }
        public string Recommendation { get; set; }
        public string Descr { get; set; }
        public DateTime Tstamp { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public bool BDel { get; set; }
        public long FormId { get; set; }
        public long ClientId { get; set; }
    }
}

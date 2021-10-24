using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTorimRecommend
    {
        public int Id { get; set; }
        public short? Type1 { get; set; }
        public bool? BDone { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
        public int? SponserId { get; set; }
        public DateTime? Date1 { get; set; }
        public int? RelatedId { get; set; }
    }
}

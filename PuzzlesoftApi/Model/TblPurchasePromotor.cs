using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPurchasePromotor
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ParitKod { get; set; }
        public int? SapakId { get; set; }
        public int? ParitCount { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPurchaseInvite
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string ParitKod { get; set; }
        public string ParitName { get; set; }
        public int? SapakId { get; set; }
        public int? ParitCount { get; set; }
        public int? DocId { get; set; }
        public decimal? ParitPrice { get; set; }
        public int? UserCreateId { get; set; }
        public int? UserInviteId { get; set; }
        public int? NStatus { get; set; }
        public DateTime? DateSapakInvite { get; set; }
        public int? PurchaseDocId { get; set; }
        public int? MelayInDocId { get; set; }
        public bool? BPrint { get; set; }
        public int UserCreateInvite { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPurchase
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date1 { get; set; }
        public int? SapakId { get; set; }
        public short? NKind { get; set; }
        public bool? Locked { get; set; }
        public bool? BUpdateMelay { get; set; }
        public int? FormId { get; set; }
        public string Memo1 { get; set; }
        public int? UserResponsible { get; set; }
        public int? FormOwnerId { get; set; }
        public short? NStatus { get; set; }
        public bool? BAllowComptroller { get; set; }
        public int? AllowComptrollerId { get; set; }
        public DateTime? AllowComptrollerDate { get; set; }
        public bool? BEnsure { get; set; }
        public int? EnsureId { get; set; }
        public DateTime? EnsureDate { get; set; }
    }
}

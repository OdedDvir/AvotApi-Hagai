using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblItemsUnique
    {
        public int Id { get; set; }
        public string ItemKod { get; set; }
        public string ItemId { get; set; }
        public string CurrentPlace { get; set; }
        public string OrgPlace { get; set; }
        public string Kod1 { get; set; }
        public string SapakName { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? Date1 { get; set; }
        public string Asmachta { get; set; }
        public string Memo1 { get; set; }
        public int? SapakId { get; set; }
        public bool? BDel { get; set; }
        public string UniqueId { get; set; }
    }
}

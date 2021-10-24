using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ClientDoc
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? FolderId { get; set; }
        public int? SnifId { get; set; }
        public int? KindId { get; set; }
        public string FileType { get; set; }
        public DateTime? ScannedDate { get; set; }
        public short? DocNameOld { get; set; }
        public short? DocDirOld { get; set; }
        public int? NumPages { get; set; }
        public int? KeyWords1 { get; set; }
        public string DocTo { get; set; }
        public string DocFrom { get; set; }
        public string WhoCreate { get; set; }
        public string WhoUpdate { get; set; }
        public DateTime? DocCreate { get; set; }
        public DateTime? DocUpdate { get; set; }
        public string FileStatus { get; set; }
        public int? UserId { get; set; }
        public double? DocSize { get; set; }
        public bool? IsFax { get; set; }
        public int? KeyWords2 { get; set; }
        public string DocNameView { get; set; }
        public string DocTheme { get; set; }
        public int? RelatedA { get; set; }
        public int? RelatedB { get; set; }
        public string Csid { get; set; }
        public bool? BDel { get; set; }
        public string DocDir { get; set; }
        public string DocName { get; set; }
        public int SubjectDocId { get; set; }
        public string Goal { get; set; }
        public DateTime? DateDoc { get; set; }
        public string SubjectDoc { get; set; }
        public bool? FlagM { get; set; }
        public string DocDirNew { get; set; }
        public string DocNameNew { get; set; }
        public bool BTelemarketing { get; set; }
        public DateTime Tstamp { get; set; }
        public bool Bsocial { get; set; }

        public virtual ClientDetail Client { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientDoc
    {
        public string DocAddress { get; set; }
        public string Docdir { get; set; }
        public bool Bsocial { get; set; }
        public DateTime? DocCreate { get; set; }
        public int Id { get; set; }
        public string DocKind { get; set; }
        public string FileType { get; set; }
        public int? KeyWords1 { get; set; }
        public string DocTo { get; set; }
        public string DocFrom { get; set; }
        public int? KeyWords2 { get; set; }
        public string DocNameView { get; set; }
        public string DocTheme { get; set; }
        public int? KindId { get; set; }
        public double? DocSize { get; set; }
        public bool? IsFax { get; set; }
        public int? FolderId { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
        public string UserCreate { get; set; }
        public bool? BDel { get; set; }
        public string DocName { get; set; }
        public string SubjectDocsName { get; set; }
        public string Goal { get; set; }
        public DateTime? DateDoc { get; set; }
    }
}

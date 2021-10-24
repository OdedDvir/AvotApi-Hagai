using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QFolder
    {
        public string NameView { get; set; }
        public string Kind { get; set; }
        public string Status { get; set; }
        public string Responsible { get; set; }
        public string Theme { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public bool? Archive { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Comments { get; set; }
        public int Id { get; set; }
        public string FolderNum { get; set; }
        public int? ResponsibleId { get; set; }
        public string FolderDetails { get; set; }
    }
}

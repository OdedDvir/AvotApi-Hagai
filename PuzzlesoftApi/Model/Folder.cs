using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Folder
    {
        public Folder()
        {
            Emails = new HashSet<Email>();
        }

        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public bool? Archive { get; set; }
        public int? ThemeId { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreate { get; set; }
        public short? KindId { get; set; }
        public int? ResponsibleId { get; set; }
        public short? StatusId { get; set; }
        public string Comments { get; set; }
        public int Id { get; set; }
        public string FolderPath { get; set; }
        public string FolderNum { get; set; }

        public virtual ICollection<Email> Emails { get; set; }
    }
}

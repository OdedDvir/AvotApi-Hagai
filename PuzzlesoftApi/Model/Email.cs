using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Email
    {
        public int Id { get; set; }
        public int? FolderId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Status { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
        public string Body { get; set; }
        public string EmailAttach { get; set; }
        public string EmailCopy { get; set; }
        public bool? FormatHtml { get; set; }
        public bool BDel { get; set; }

        public virtual Folder Folder { get; set; }
    }
}

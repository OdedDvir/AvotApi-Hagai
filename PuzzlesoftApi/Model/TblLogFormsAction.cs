using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblLogFormsAction
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string Vbform { get; set; }
        public long? FormTemplateId { get; set; }
        public long? ClientFormId { get; set; }
        public DateTime? TStamp { get; set; }
        public long? ClientId { get; set; }
        public string Action1 { get; set; }
    }
}

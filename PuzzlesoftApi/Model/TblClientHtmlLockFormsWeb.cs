using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHtmlLockFormsWeb
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string FormHtml { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public int A3 { get; set; }
    }
}

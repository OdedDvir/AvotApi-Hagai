using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefHtmlFormsWeb
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int SubjectId { get; set; }
        public string FormKey { get; set; }
        public string GroupKey { get; set; }
        public bool BMain { get; set; }
        public bool BArchive { get; set; }
        public string FormProc { get; set; }
        public DateTime TStamp { get; set; }
        public int LocationId { get; set; }
        public string PrAfterLock { get; set; }
        public bool ShowLock { get; set; }
        public bool ShowLink { get; set; }
        public bool ShowSave { get; set; }
        public bool ShowSaveAndBack { get; set; }
        public bool ShowOpenClose { get; set; }
        public int NType { get; set; }
        public int NPointAll { get; set; }
        public bool ShowClientHead { get; set; }
        public bool ShowClientHeaderHtml { get; set; }
        public bool ShowClientHeaderTnuot { get; set; }
        public bool ShowCopy { get; set; }
        public int A3 { get; set; }
        public string Harsha { get; set; }
    }
}

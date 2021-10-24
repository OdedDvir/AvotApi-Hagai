using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBakaratTrufot
    {
        public long Id { get; set; }
        public DateTime? FormDate { get; set; }
        public long? UserId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? Tsatmp { get; set; }
        public bool? BConfirmDoctor { get; set; }
        public bool? BConfirmNurse { get; set; }
        public string Comments { get; set; }
        public string HtmlSrc { get; set; }
        public long? ClientId { get; set; }
        public string ClientName { get; set; }
        public bool? BDel { get; set; }
        public bool? BLocked { get; set; }
        public string ClientArr { get; set; }
    }
}

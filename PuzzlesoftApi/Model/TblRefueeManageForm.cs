using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRefueeManageForm
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public DateTime Date1 { get; set; }
        public bool? Locked { get; set; }
        public int? RekaId { get; set; }
        public int? SikumId { get; set; }
        public int? SkiraId { get; set; }
        public int? Skira2Id { get; set; }
        public string ListLocked { get; set; }
        public string FormKind { get; set; }
        public bool? BImport { get; set; }
        public int? NConv { get; set; }
        public DateTime? TscreateDate { get; set; }
        public bool? BConv { get; set; }
        public bool? BConv2 { get; set; }
        public string DateTmp { get; set; }
        public int? BackClientId { get; set; }
        public string UserIdcreate { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool LockedFlag { get; set; }
        public DateTime? TsLockedDate { get; set; }
        public DateTime TsLockedKabala { get; set; }
        public bool BPsychiatry { get; set; }
        public string UserLocked { get; set; }
        public string UserCreated { get; set; }
    }
}

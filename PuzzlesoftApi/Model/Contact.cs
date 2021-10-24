using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Contact
    {
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string Details { get; set; }
        public int? ClientId { get; set; }
        public int Id { get; set; }
        public int? KindId { get; set; }
        public int? UserId { get; set; }
        public int? UserIdcreate { get; set; }
        public string LinkAddress { get; set; }
        public string LinkFile { get; set; }
        public int? LinkFileId { get; set; }
        public string ContactTheme { get; set; }
        public bool? BDel { get; set; }
        public string StaffInclude { get; set; }
        public string MeetCreate { get; set; }
        public string Theme { get; set; }
        public string UserCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public int? UserCreateid { get; set; }
        public string ContactTheme2 { get; set; }
        public short MeetYozemId { get; set; }
        public int FormId { get; set; }
        public bool? BIncludeHanhala { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblContact
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string Details { get; set; }
        public int KindId { get; set; }
        public string ContactTheme { get; set; }
        public bool BDel { get; set; }
        public string StaffInclude { get; set; }
        public short MeetYozemId { get; set; }
        public int ParentId { get; set; }
        public int UserIdcreate { get; set; }
        public int UserIdupdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime? TStampUpdate { get; set; }
    }
}

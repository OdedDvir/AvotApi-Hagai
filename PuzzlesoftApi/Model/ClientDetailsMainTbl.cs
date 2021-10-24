using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ClientDetailsMainTbl
    {
        public int Id { get; set; }
        public string NameView { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string IdCard { get; set; }
        public int? MainKind { get; set; }
        public bool? Archive { get; set; }
        public short? LocationId { get; set; }
        public int? Mahlakaid { get; set; }
        public int? Clientid { get; set; }
    }
}

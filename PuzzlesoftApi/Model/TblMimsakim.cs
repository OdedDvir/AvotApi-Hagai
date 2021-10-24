using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMimsakim
    {
        public int Id { get; set; }
        public short? KindId { get; set; }
        public short? KindId2 { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Name1 { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public int? LocationId { get; set; }
        public string ListId { get; set; }
        public string ListId2 { get; set; }
        public string ListId3 { get; set; }
        public string ListId4 { get; set; }
        public string ListXml1 { get; set; }
        public string ListXml2 { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Maham1 { get; set; }
        public string ListId5 { get; set; }
        public string ListId6 { get; set; }
        public bool BUnLock { get; set; }
        public bool Bexp { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
    }
}

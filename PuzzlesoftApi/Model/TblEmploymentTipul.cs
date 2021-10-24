using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblEmploymentTipul
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string TipulOrGar { get; set; }
        public string GroupsName { get; set; }
        public string GroupsId { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
        public string TimeGroup { get; set; }
        public string SubjectGroup { get; set; }
        public string Accessory { get; set; }
        public string Other { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? Bdel { get; set; }
    }
}

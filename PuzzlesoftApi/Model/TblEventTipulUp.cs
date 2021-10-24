using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblEventTipulUp
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Whorep { get; set; }
        public DateTime? Date1 { get; set; }
        public string Desctipul { get; set; }
        public DateTime? TStamp { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public int? Formid { get; set; }
        public bool? Bdel { get; set; }
        public string Reported { get; set; }
    }
}

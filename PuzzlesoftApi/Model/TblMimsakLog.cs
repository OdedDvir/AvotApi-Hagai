using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMimsakLog
    {
        public int Id { get; set; }
        public string ListId { get; set; }
        public string Type1 { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public int? NumSuccess { get; set; }
        public int? NumFail { get; set; }
        public int? NumAll { get; set; }
    }
}

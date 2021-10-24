using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHeshSafe
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? HomeDelegate { get; set; }
        public DateTime? Date1 { get; set; }
        public string Description { get; set; }
        public bool? Action { get; set; }
        public bool? Bdel { get; set; }
        public DateTime? Tstamp { get; set; }
        public int? UserCreateId { get; set; }
    }
}

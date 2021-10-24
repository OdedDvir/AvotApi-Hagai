using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTyingGave
    {
        public int Id { get; set; }
        public int TyingId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Memo1 { get; set; }
        public int UserCreateId { get; set; }
        public DateTime TsTamp { get; set; }
    }
}

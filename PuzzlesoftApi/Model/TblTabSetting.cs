using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTabSetting
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string TabNum { get; set; }
        public string Memo1 { get; set; }
        public int? Type1 { get; set; }
    }
}

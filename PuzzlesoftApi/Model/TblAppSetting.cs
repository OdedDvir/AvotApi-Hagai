using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAppSetting
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public short? LocationId { get; set; }
        public int? UserId { get; set; }
        public string Val1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientSetting
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public int? ClientId { get; set; }
        public string Val1 { get; set; }
    }
}

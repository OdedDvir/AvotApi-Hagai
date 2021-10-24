using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientGeneralKnowledge
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public short? ThemeId { get; set; }
        public string Description { get; set; }
    }
}

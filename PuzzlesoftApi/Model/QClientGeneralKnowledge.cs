using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientGeneralKnowledge
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Description { get; set; }
        public string Theme { get; set; }
    }
}

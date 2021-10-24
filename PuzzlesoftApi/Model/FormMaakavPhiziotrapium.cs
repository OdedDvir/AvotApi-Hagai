using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormMaakavPhiziotrapium
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public short? RecStatus { get; set; }
        public string UserName { get; set; }
        public DateTime? Date1 { get; set; }
        public string Item { get; set; }
        public string Theme { get; set; }
    }
}

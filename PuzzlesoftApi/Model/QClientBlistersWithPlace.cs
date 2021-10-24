using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientBlistersWithPlace
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? ClientId { get; set; }
        public short? BlisterStatusId { get; set; }
    }
}

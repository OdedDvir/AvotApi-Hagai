using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAvhanotTran
    {
        public int Id { get; set; }
        public string Avhanakod { get; set; }
        public string AvhanakodNew { get; set; }
        public bool NotAvhana { get; set; }
    }
}

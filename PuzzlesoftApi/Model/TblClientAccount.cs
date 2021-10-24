using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientAccount
    {
        public int Id { get; set; }
        public long ClientId { get; set; }
        public long? Account { get; set; }
        public long? Snif { get; set; }
        public long? BankId { get; set; }
        public string SponserId { get; set; }
        public bool? IsMasav { get; set; }
        public short? MasavDay { get; set; }
        public bool? BDel { get; set; }
    }
}

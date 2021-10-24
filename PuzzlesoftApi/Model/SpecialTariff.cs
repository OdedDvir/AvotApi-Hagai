using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class SpecialTariff
    {
        public int? ClientId { get; set; }
        public int? TariffId { get; set; }
        public string TariffSpecial { get; set; }
    }
}

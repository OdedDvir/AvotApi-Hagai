using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefKupaSnif
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? KupaId { get; set; }
    }
}

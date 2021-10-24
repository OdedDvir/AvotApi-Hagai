using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefPayMethod
    {
        public short Id { get; set; }
        public string Item { get; set; }
        public string HeshId { get; set; }
        public int? Locationid { get; set; }
        public int? NKind { get; set; }
        public int KupaId { get; set; }
    }
}

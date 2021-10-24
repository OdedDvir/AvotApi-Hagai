using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAcLog
    {
        public int Id { get; set; }
        public string AcType { get; set; }
        public int? UserCreateId { get; set; }
        public string AcKind { get; set; }
        public int? AcRecId { get; set; }
    }
}

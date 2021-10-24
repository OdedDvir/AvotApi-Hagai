using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TbldefTimeType
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? OrderId { get; set; }
        public bool? BArchive { get; set; }
        public int? NTime { get; set; }
        public int? CompanyId { get; set; }
        public string Kod1 { get; set; }
    }
}

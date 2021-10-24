using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TbldefItemType
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? OrderId { get; set; }
        public bool? BArchive { get; set; }
        public int? CompanyId { get; set; }
    }
}

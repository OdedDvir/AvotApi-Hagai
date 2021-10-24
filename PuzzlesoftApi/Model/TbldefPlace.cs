using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TbldefPlace
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int? CompanyId { get; set; }
        public bool? BArchive { get; set; }
    }
}

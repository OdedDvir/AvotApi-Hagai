using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRefueeMangeDetail
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Key1 { get; set; }
        public string ListId { get; set; }
        public DateTime? Date1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TorimRecommendDetail
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public int? ParentId { get; set; }
        public int? TorType { get; set; }
        public string Kod1 { get; set; }
        public int? Num1 { get; set; }
    }
}

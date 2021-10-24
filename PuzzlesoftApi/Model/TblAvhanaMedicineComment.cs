using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAvhanaMedicineComment
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int? AvhanaId { get; set; }
        public string Comments { get; set; }
        public int? UserId { get; set; }
        public DateTime? Tstamp { get; set; }
        public int CommentId { get; set; }
        public string CommentKey { get; set; }
    }
}

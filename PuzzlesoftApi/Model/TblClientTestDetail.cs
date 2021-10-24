using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTestDetail
    {
        public int Id { get; set; }
        public int? ClientTestId { get; set; }
        public int? TestDetailId { get; set; }
        public bool? IsNotCorrect { get; set; }
        public string Value1 { get; set; }
        public string AnswerList { get; set; }
    }
}

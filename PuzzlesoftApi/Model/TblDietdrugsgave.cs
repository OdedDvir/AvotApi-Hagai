using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietdrugsgave
    {
        public int Id { get; set; }
        public int DrugId { get; set; }
        public int Kind { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string Memo1 { get; set; }
        public int? UserId { get; set; }
        public DateTime TsCreate { get; set; }
        public int GaveStatus { get; set; }
    }
}

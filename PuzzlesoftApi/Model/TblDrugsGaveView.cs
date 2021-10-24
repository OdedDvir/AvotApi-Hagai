using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugsGaveView
    {
        public int Id { get; set; }
        public int DrugId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string TimeGave { get; set; }
        public string Memo1 { get; set; }
        public int UserCreateid { get; set; }
        public int GaveStatus { get; set; }
        public DateTime TsTamp { get; set; }
    }
}

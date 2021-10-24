using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugsGaveDeleted
    {
        public int Id { get; set; }
        public int Iddel { get; set; }
        public int? DrugId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string Minun { get; set; }
        public string Memo1 { get; set; }
        public int? UserCreateid { get; set; }
        public DateTime? TStame { get; set; }
        public double? MinunNum { get; set; }
        public int? GaveStatus { get; set; }
        public DateTime? TsTamp { get; set; }
        public DateTime TsTampDel { get; set; }
    }
}

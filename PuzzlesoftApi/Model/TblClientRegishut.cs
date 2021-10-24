using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientRegishut
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Theme { get; set; }
        public string Effect { get; set; }
        public string DateS { get; set; }
        public string UserCreate { get; set; }
        public string DrugKod { get; set; }
        public bool BDel { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public int? OrderId { get; set; }
        public int? KabalaId { get; set; }
        public string ConsiderName { get; set; }
        public bool? BConv { get; set; }
        public bool? BConv2 { get; set; }
        public bool BUnKnown { get; set; }
        public int? RecType { get; set; }
        public int FormId { get; set; }
    }
}

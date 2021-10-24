using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugsNotGiven
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string DrugNotGiven { get; set; }
        public string Reason { get; set; }
        public int UserId { get; set; }
        public string UserCreate { get; set; }
        public bool BDel { get; set; }
        public int FormPkudotId { get; set; }
        public int? KabalaId { get; set; }
        public DateTime? TStamp { get; set; }
        public string DrugKod { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFollowDonce
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string DrugOnce { get; set; }
        public string Val1 { get; set; }
        public int UserId { get; set; }
        public string UserCreate { get; set; }
        public bool BDel { get; set; }
        public DateTime? TStamp { get; set; }
        public string DrugKod { get; set; }
        public int? DrugId { get; set; }
    }
}

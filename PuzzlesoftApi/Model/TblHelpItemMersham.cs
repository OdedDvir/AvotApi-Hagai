using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHelpItemMersham
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FormId { get; set; }
        public string DrugName { get; set; }
        public DateTime DateS { get; set; }
        public DateTime DateE { get; set; }
        public string Minun { get; set; }
        public int? Quantity { get; set; }
        public string DrugFormat { get; set; }
        public string TypeToInvite { get; set; }
        public string Comment { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool BDel { get; set; }
    }
}

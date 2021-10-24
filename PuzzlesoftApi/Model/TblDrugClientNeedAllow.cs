using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDrugClientNeedAllow
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string DrugKod { get; set; }
        public string DrugName { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
    }
}

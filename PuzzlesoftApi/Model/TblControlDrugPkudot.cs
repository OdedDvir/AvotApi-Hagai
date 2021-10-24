using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblControlDrugPkudot
    {
        public int Id { get; set; }
        public int DrugId { get; set; }
        public int FormId { get; set; }
        public int Clientid { get; set; }
        public int Type1 { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
    }
}

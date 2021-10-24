using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormAvhanotDiet
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FormId { get; set; }
        public string Avhanakod { get; set; }
        public string Status { get; set; }
        public string AvahanaFull { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? DateE { get; set; }
        public string UserCreate { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public bool BDel { get; set; }
    }
}

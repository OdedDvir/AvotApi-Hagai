using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPkodutTemporarySclient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateB { get; set; }
        public DateTime? DateE { get; set; }
        public TimeSpan? TimeB { get; set; }
        public TimeSpan? TimeE { get; set; }
        public string DrugName { get; set; }
        public string DrugKod { get; set; }
        public int? DrugId { get; set; }
        public string Reason { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? Bdel { get; set; }
    }
}

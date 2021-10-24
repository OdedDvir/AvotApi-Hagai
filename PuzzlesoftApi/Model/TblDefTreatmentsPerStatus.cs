using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefTreatmentsPerStatus
    {
        public int Id { get; set; }
        public int TifkudStatusId { get; set; }
        public int TipulId { get; set; }
        public int? TakePerDay { get; set; }
        public string DrugTakeTimes { get; set; }
        public string DrugTakeDays { get; set; }
        public string Memo { get; set; }
        public bool? BDel { get; set; }
        public long? UserCreateId { get; set; }
    }
}

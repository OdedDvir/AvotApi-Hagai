using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblleaderWorker
    {
        public int Id { get; set; }
        public string WorkerId { get; set; }
        public int LeaderSubjectId { get; set; }
        public DateTime DateCreate { get; set; }
        public string Memo { get; set; }
        public int UserCreateId { get; set; }
        public bool BDel { get; set; }
        public string LeaderSubjectList { get; set; }
        public string TreatName { get; set; }
        public string ListMahlakaId { get; set; }
        public string WokerName { get; set; }
        public int? MedicalType { get; set; }
        public string ProfilId { get; set; }
        public string ProfileId { get; set; }
    }
}

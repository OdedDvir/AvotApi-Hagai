using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientVaccination
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Theme { get; set; }
        public string DateOld { get; set; }
        public string Memo1 { get; set; }
        public string Atsva { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public DateTime? DateS1 { get; set; }
        public int? OrderId { get; set; }
        public int? KabalaId { get; set; }
        public string UserCreate { get; set; }
        public bool? BDel { get; set; }
        public DateTime? DateS { get; set; }
        public string VaccinationName { get; set; }
        public int FormId { get; set; }
    }
}

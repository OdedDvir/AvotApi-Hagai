using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTreatmentPlanReport
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FormId { get; set; }
        public string Report { get; set; }
        public string RepType { get; set; }
        public DateTime DateR { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool BDel { get; set; }
    }
}

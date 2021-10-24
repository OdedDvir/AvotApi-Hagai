using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblGeneralNurseDetailA10
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public int? MahlakaId { get; set; }
        public int? MishmeretId { get; set; }
        public string Mahlaka { get; set; }
        public string Mishmeret { get; set; }
        public string DoctorName { get; set; }
        public int? UserId { get; set; }
        public string UserCreate { get; set; }
        public string Rep { get; set; }
        public DateTime? SCurrentDate { get; set; }
        public bool? BDel { get; set; }
    }
}

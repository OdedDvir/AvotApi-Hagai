using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientHospStatus
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreate { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public bool? BDel { get; set; }
        public string Comments { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
    }
}

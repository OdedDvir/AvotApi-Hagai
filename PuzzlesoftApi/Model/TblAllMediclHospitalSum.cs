using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAllMediclHospitalSum
    {
        public int Id { get; set; }
        public string Summery { get; set; }
        public int UserIdCreteId { get; set; }
        public int MedicalGroupId { get; set; }
        public DateTime DateCreate { get; set; }
        public bool SType { get; set; }
        public bool BDel { get; set; }
        public int? ClientId { get; set; }
        public long? FormId { get; set; }
    }
}

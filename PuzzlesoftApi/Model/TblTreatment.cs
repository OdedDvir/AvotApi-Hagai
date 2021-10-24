using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblTreatment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public string Entitle { get; set; }
        public string NumHoursWeeks { get; set; }
        public string Plans { get; set; }
        public string WorkerIdA { get; set; }
        public string TelA { get; set; }
        public string WorkerIdb { get; set; }
        public string TelB { get; set; }
        public DateTime? DateCreate { get; set; }
        public int UserCreateId { get; set; }
        public bool BDel { get; set; }
        public string TelC { get; set; }
        public string WorkerIdC { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}

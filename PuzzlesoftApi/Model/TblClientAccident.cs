using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientAccident
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public DateTime? DateEvent { get; set; }
        public string TimeEvent { get; set; }
        public int? MahlakaId { get; set; }
        public string EventKind { get; set; }
        public string EventReason { get; set; }
        public string Details { get; set; }
        public bool? WitnessDayar { get; set; }
        public string WitnessWorker { get; set; }
        public string Witness { get; set; }
        public string CheckDetails { get; set; }
        public int? ReporterId { get; set; }
        public int? MainNurseId { get; set; }
        public int? DoctorId { get; set; }
        public string DocTime { get; set; }
        public string DocCheck { get; set; }
        public DateTime? DocCheckDate { get; set; }
        public string DocCheckTime { get; set; }
        public string Bakara { get; set; }
        public DateTime? BakaraDate { get; set; }
        public int? BakaraUserId { get; set; }
        public string ManagerNote { get; set; }
        public DateTime? ManagerDate { get; set; }
        public int? ManagerUserId { get; set; }
    }
}

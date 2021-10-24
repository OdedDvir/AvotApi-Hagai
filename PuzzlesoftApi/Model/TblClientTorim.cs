using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTorim
    {
        public int? ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string Clinic { get; set; }
        public string Doctor { get; set; }
        public string Room { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Comments { get; set; }
        public int Id { get; set; }
        public short? BStatus { get; set; }
        public int? TransId { get; set; }
        public string Results { get; set; }
        public DateTime? DateReminder { get; set; }
        public string TimeReminder { get; set; }
        public short? MedicalGroupId { get; set; }
        public string MedicalGroup { get; set; }
        public int? Mange17Id { get; set; }
        public string Mange17 { get; set; }
        public bool? BAmbulance { get; set; }
        public bool? BEscort { get; set; }
        public string EscortDetails { get; set; }
        public string Ambulancekind { get; set; }
        public long? TransferalId { get; set; }
        public string EscortPhon { get; set; }
    }
}

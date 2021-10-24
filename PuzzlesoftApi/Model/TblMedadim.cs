using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMedadim
    {
        public int Id { get; set; }
        public string MeasurmentId { get; set; }
        public string HospitalId { get; set; }
        public string PatientId { get; set; }
        public string PatientbikoretId { get; set; }
        public string IdTypes { get; set; }
        public string CaseNumber { get; set; }
        public int? OtherHosp { get; set; }
        public string SurgDepId { get; set; }
        public string HospDate { get; set; }
        public string HospTime { get; set; }
        public string DischargeDate { get; set; }
        public int? BirthYear { get; set; }
        public int? Gender { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouse { get; set; }
        public string AddressCityName { get; set; }
        public int? CityCode { get; set; }
        public int? Ses { get; set; }
        public string SurgeryStartDate { get; set; }
        public string SurgeryStartTime { get; set; }
        public string SurgeryEndDate { get; set; }
        public string SurgeryEndTime { get; set; }
        public string AnasStartDate { get; set; }
        public string AnasStartTime { get; set; }
        public string AnasEndDate { get; set; }
        public string AnasEndTime { get; set; }
        public string DiagnosisIcd { get; set; }
        public string ProcedureIcd { get; set; }
        public string ProcedureIcdLocal { get; set; }
        public string Remarks { get; set; }
    }
}

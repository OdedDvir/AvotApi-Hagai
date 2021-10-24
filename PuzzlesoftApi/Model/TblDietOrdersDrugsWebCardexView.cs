using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietOrdersDrugsWebCardexView
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int Groupid { get; set; }
        public short RecStatus { get; set; }
        public string DrugName { get; set; }
        public DateTime? Datee2 { get; set; }
        public string DrugTakeDays { get; set; }
        public short? DrugTakeJumpDays { get; set; }
        public int Clientid { get; set; }
        public int? KabalaId { get; set; }
        public string Category { get; set; }
        public short RecKind { get; set; }
        public string SubmissionForm { get; set; }
        public DateTime? Tscreate { get; set; }
        public string DatesCardex { get; set; }
        public string GivingWay { get; set; }
        public string GivingManner { get; set; }
        public string Dosage { get; set; }
        public string Dosage2 { get; set; }
        public string FeedRate { get; set; }
        public string Dates { get; set; }
        public string DrugTakeTimes { get; set; }
        public string DateE { get; set; }
        public string TtDateE { get; set; }
        public string DrugComments { get; set; }
        public string UserCreate { get; set; }
        public string NumHourDay { get; set; }
        public string TimeS { get; set; }
        public string TimeE { get; set; }
        public DateTime DateS2 { get; set; }
    }
}

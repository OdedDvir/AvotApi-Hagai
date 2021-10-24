using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietOrdersDrugsWebTemp
    {
        public int Id { get; set; }
        public int Kind { get; set; }
        public int ClientId { get; set; }
        public int GroupId { get; set; }
        public int FormId { get; set; }
        public short RecKind { get; set; }
        public short RecStatus { get; set; }
        public string DrugKod { get; set; }
        public short DrugType { get; set; }
        public short DrugTakeKind { get; set; }
        public short DrugGivingManner { get; set; }
        public short DrugSubmissionFrm { get; set; }
        public int? FeedRate { get; set; }
        public string NumHourDay { get; set; }
        public string DrugComments { get; set; }
        public DateTime DateS { get; set; }
        public DateTime? DateE { get; set; }
        public string DrugTakeDays { get; set; }
        public string DrugTakeTimes { get; set; }
        public string DrugMinunNum { get; set; }
        public int? UnitofMeasureId { get; set; }
        public short? DrugTakeJumpDays { get; set; }
        public int? KabalaId { get; set; }
        public int? FoodId { get; set; }
        public int? OrderId { get; set; }
        public int PlanId { get; set; }
        public int UserIdcreate { get; set; }
        public int? UserIdupdate { get; set; }
        public DateTime? TsCreate { get; set; }
        public DateTime? TsUpdate { get; set; }
        public int? StopUserId { get; set; }
        public string Stopresone { get; set; }
        public int TakePerDay { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietOrdersDrug
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public short? RecKind { get; set; }
        public short? RecStatus { get; set; }
        public string UserName { get; set; }
        public short? DrugKind { get; set; }
        public string DrugName { get; set; }
        public string DrugKod { get; set; }
        public float? TakePerOne { get; set; }
        public float? TakePerDay { get; set; }
        public float? NumToInvite { get; set; }
        public short? DrugType { get; set; }
        public string DrugTakeKind { get; set; }
        public string DrugComments { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? DateE { get; set; }
        public string DrugTakeDays { get; set; }
        public string DrugTakeTimes { get; set; }
        public string DrugFormat { get; set; }
        public string DrugMinunType { get; set; }
        public string DrugMinunNum { get; set; }
        public short? DrugTakeJumpDays { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStamp { get; set; }
        public int? KabalaId { get; set; }
        public string UserCreate { get; set; }
        public string DrugGenricName { get; set; }
        public bool? BMoveToActive { get; set; }
        public int? FoodId { get; set; }
        public int? OrderId { get; set; }
        public int? IsRead { get; set; }
        public DateTime? ReadTime { get; set; }
        public bool? BDel { get; set; }
        public int? WorkerId { get; set; }
        public int? DrugId { get; set; }
        public string TipulName { get; set; }
        public string TipulDetails { get; set; }
        public int TipulId { get; set; }
        public bool IsTipul { get; set; }
        public short ResponsibleGroupId { get; set; }
        public int FormId { get; set; }
        public int PlanId { get; set; }
        public string DrugAvhanaKod { get; set; }
        public int? StopUserId { get; set; }
    }
}

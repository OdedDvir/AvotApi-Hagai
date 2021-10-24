using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDietOrder
    {
        public int Id { get; set; }
        public int? TypeForm { get; set; }
        public string FormId { get; set; }
        public int? ClientId { get; set; }
        public string UserCreate { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateS { get; set; }
        public DateTime? DateE { get; set; }
        public string Additive { get; set; }
        public string Unit { get; set; }
        public float? Dosage { get; set; }
        public int? Times { get; set; }
        public string Advice { get; set; }
        public int? ToMedicalGroupId { get; set; }
        public short? OrderKindId { get; set; }
        public short RecStatus { get; set; }
        public DateTime? TStamp { get; set; }
        public string LunchId { get; set; }
        public string LunchDesc { get; set; }
        public int? MenuId { get; set; }
        public int? FoodId { get; set; }
        public int? UserId2 { get; set; }
        public string UserCreate2 { get; set; }
        public DateTime? DateOk { get; set; }
        public bool? BDel { get; set; }
        public int? DrugId { get; set; }
        public bool? Okread { get; set; }
        public string OkrComment { get; set; }
        public int? MirkamId { get; set; }
        public int? FeedMethodId { get; set; }
        public string AdditiveId { get; set; }
        public string ReasonStop { get; set; }
        public string ResonStop { get; set; }
    }
}

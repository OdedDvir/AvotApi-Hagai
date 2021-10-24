using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormsTemplate
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public int? UserIdcreate { get; set; }
        public string SType { get; set; }
        public bool Locked { get; set; }
        public bool Archive { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public double? CorrectMin { get; set; }
        public double? CorrectMax { get; set; }
        public string HtmlSource { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string FormKey { get; set; }
        public string HtmlSourceEng { get; set; }
        public int? NumRequest { get; set; }
        public string QuestionFirst1 { get; set; }
        public int? PointMin1 { get; set; }
        public int? PointMax1 { get; set; }
        public int? NumQuestionMust1 { get; set; }
        public string QuestionFirst2 { get; set; }
        public string QuestionLast2 { get; set; }
        public int? PointMin2 { get; set; }
        public int? PointMax2 { get; set; }
        public int? NumQuestionMust2 { get; set; }
        public string QuestionLast1 { get; set; }
        public bool? BZeroTest { get; set; }
        public int OrderId { get; set; }
        public string FormKeyGroup { get; set; }
        public int MedicalGroupId { get; set; }
    }
}

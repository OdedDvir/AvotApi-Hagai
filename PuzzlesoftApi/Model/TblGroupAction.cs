using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblGroupAction
    {
        public int Id { get; set; }
        public int? MedicalGroupId { get; set; }
        public DateTime? DateAction { get; set; }
        public int? SubjectActionId { get; set; }
        public string ClientsId { get; set; }
        public string Describe { get; set; }
        public int? Operationid { get; set; }
        public string Operation { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? Bdel { get; set; }
        public string Criterion { get; set; }
        public string Comments { get; set; }
        public string CriterionId { get; set; }
        public int? GroupId { get; set; }
    }
}

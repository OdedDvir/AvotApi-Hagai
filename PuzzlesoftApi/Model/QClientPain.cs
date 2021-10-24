using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientPain
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int Formid { get; set; }
        public DateTime? DateTime1 { get; set; }
        public bool? BOmdanAgain { get; set; }
        public string Date1 { get; set; }
        public string Time { get; set; }
        public int NStatus { get; set; }
        public string StatusDesc { get; set; }
        public string NameviewAndStatus { get; set; }
        public int? LevelId { get; set; }
        public string LevelDesc { get; set; }
        public string Place { get; set; }
        public string Causes { get; set; }
        public string Symptoms { get; set; }
        public string PainKind { get; set; }
        public string TipulKind { get; set; }
        public string DrugKod { get; set; }
        public string DrugName { get; set; }
        public string Comments { get; set; }
        public string LevelSelectedId { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public int? SubjectId { get; set; }
        public DateTime TStamp { get; set; }
        public bool? BDel { get; set; }
    }
}

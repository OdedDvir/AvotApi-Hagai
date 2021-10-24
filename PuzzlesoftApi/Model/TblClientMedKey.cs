using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientMedKey
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public string Val1 { get; set; }
        public string UserName { get; set; }
        public int ClientId { get; set; }
        public int? FormId { get; set; }
        public string Theme { get; set; }
        public int? KabalaId { get; set; }
        public int? UserCreateId { get; set; }
        public bool? BDel { get; set; }
        public string UserCreate { get; set; }
        public string FilePath { get; set; }
    }
}

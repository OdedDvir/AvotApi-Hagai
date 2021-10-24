using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientGroupAction
    {
        public int Id { get; set; }
        public string Kind1 { get; set; }
        public string Theme1 { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public short? MedicalGroupId { get; set; }
        public string Responsible { get; set; }
        public int? UserId { get; set; }
        public string Target1 { get; set; }
        public string ClientIdlist { get; set; }
        public string Summery { get; set; }
        public short? LocationId { get; set; }
        public bool? BDel { get; set; }
    }
}

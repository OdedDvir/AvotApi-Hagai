using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDoctor1
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string NameView { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Mobile1 { get; set; }
        public string Fax1 { get; set; }
        public string Email { get; set; }
        public bool? Tel1Private { get; set; }
        public bool? Tel2Private { get; set; }
        public bool? Fax1Private { get; set; }
        public bool? EmailPrivate { get; set; }
        public bool? Mobile1Private { get; set; }
        public int? Subject1 { get; set; }
        public int? Subject2 { get; set; }
        public int? Subject3 { get; set; }
        public int? Subject4 { get; set; }
        public string Kod1Def { get; set; }
        public bool? BArchive { get; set; }
        public int? CompanyId { get; set; }
    }
}

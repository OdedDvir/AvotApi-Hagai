using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormMedahRefuee
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public bool? BClosed { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FamilyStatus { get; set; }
        public short? Childs { get; set; }
        public string Job { get; set; }
        public string BirthCountry { get; set; }
        public string BirthYear { get; set; }
        public string AliaYear { get; set; }
        public string Bituah { get; set; }
    }
}

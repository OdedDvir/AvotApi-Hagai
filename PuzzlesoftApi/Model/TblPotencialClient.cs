using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPotencialClient
    {
        public int Id { get; set; }
        public string IdCard { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string NameView { get; set; }
        public string BearthDay1 { get; set; }
        public string BearthCountry { get; set; }
        public string FatherName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNum { get; set; }
        public string Zip { get; set; }
        public int? Gender { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? BearthDay { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public short? LocationId { get; set; }
        public string Comments { get; set; }
        public short? HufnaTo { get; set; }
        public int? MaagarId { get; set; }
        public DateTime? TimeInsert { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }
    }
}

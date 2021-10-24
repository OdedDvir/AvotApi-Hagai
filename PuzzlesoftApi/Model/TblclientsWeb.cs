using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblclientsWeb
    {
        public int Id { get; set; }
        public string NameView { get; set; }
        public string UniqId { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public short NType { get; set; }
        public bool Archive { get; set; }
        public short LocationId { get; set; }
        public int UserId { get; set; }
        public DateTime TStamp { get; set; }
        public string IdCard { get; set; }
        public int NConv { get; set; }
        public int AppDoctorId { get; set; }
        public int AvotId { get; set; }
        public bool BPassport { get; set; }
        public int MainKind { get; set; }
        public int UserIdCreate { get; set; }
        public int UserIdUpdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime TStampUpdate { get; set; }
        public int AvotWorkerId { get; set; }
        public string Fnameeng { get; set; }
        public string Lnameeng { get; set; }
    }
}

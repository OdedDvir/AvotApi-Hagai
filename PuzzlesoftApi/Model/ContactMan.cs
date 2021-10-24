using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ContactMan
    {
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Street { get; set; }
        public int? JobId { get; set; }
        public int? CityId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public int? ClientId { get; set; }
        public int Id { get; set; }
        public string Info { get; set; }
        public int? UserId { get; set; }
        public bool? ChkOutlook { get; set; }
        public bool? Main { get; set; }
        public string Birthday { get; set; }
        public string Idcard { get; set; }
        public string Zip { get; set; }
        public string Street2 { get; set; }
        public bool? ChkCouple { get; set; }
        public int? KirvaId { get; set; }
        public int? NConv { get; set; }
        public string UserCreate { get; set; }
        public int FormId { get; set; }
        public bool BAllowSms { get; set; }

        public virtual ClientDetail Client { get; set; }
    }
}

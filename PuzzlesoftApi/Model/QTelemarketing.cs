using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QTelemarketing
    {
        public string NameView { get; set; }
        public string Idcard { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string MailBox { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string City { get; set; }
        public string Sponser { get; set; }
        public string Mafne { get; set; }
        public string TifkudStatus { get; set; }
        public DateTime? DateFirst { get; set; }
        public string MarketingStatus { get; set; }
        public int Id { get; set; }
        public int? CityId { get; set; }
        public short? LocationId { get; set; }
        public bool? Archive { get; set; }
        public short? MainKind { get; set; }
    }
}

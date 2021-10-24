using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QContractGuest
    {
        public int? TnuahId { get; set; }
        public string NameView { get; set; }
        public string RelatedNameView { get; set; }
        public string RelatedIdcard { get; set; }
        public string RelatedStreet { get; set; }
        public string RelatedCity { get; set; }
        public string Idcard { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string GuestMadadMonth { get; set; }
        public string GuestPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ContactMen1
    {
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Phone1 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public bool? Main { get; set; }
        public string Phone2 { get; set; }
        public string Kirva { get; set; }
    }
}

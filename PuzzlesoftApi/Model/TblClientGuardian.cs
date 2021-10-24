using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientGuardian
    {
        public int Id { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Field { get; set; }
        public string Street { get; set; }
        public int? CityId { get; set; }
        public string Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Info { get; set; }
        public int? ClientId { get; set; }
        public int? KirvaId { get; set; }
        public bool GetSms { get; set; }
        public string DocNameView { get; set; }
        public string DocName { get; set; }

        public virtual ClientDetail Client { get; set; }
    }
}

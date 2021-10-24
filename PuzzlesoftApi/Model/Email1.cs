using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Email1
    {
        public int? ClientId { get; set; }
        public DateTime? EmailDetails { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public int EmailId { get; set; }
    }
}

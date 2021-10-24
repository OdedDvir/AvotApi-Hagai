using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class BiVclientDetail
    {
        public int Id { get; set; }
        public string NameView { get; set; }
        public string Idcard { get; set; }
        public bool? Archive { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }
}

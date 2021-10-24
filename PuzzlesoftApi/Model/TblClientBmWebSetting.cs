using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientBmWebSetting
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string BmwebUserName { get; set; }
        public string BmwebKupa { get; set; }
        public string BmwebPassword { get; set; }
        public bool? Archive { get; set; }
        public string LastUpdatePass { get; set; }
        public string SModePass { get; set; }
        public string LastDate { get; set; }
        public string BmwebCard { get; set; }
    }
}

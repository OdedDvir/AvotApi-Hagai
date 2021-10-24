using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblErrPdfFollow
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public int Followid { get; set; }
        public string Desc { get; set; }
    }
}

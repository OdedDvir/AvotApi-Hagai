using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBiocomMain
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public int UserId { get; set; }
        public short LocationId { get; set; }
        public string FileName { get; set; }
    }
}

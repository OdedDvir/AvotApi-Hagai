using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientNehalim
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? TStampCreate { get; set; }
        public bool BDel { get; set; }
        public string ThemeName { get; set; }
        public string FileName { get; set; }
        public string NohalNum { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientRespirationMadad
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public DateTime? Date1 { get; set; }
        public int? Formid { get; set; }
        public double? Ve { get; set; }
        public double? Rate { get; set; }
        public double? Vt { get; set; }
        public double? Pip { get; set; }
        public double? Ps { get; set; }
        public double? C { get; set; }
        public double? R { get; set; }
        public double? Rc { get; set; }
        public double? Sat { get; set; }
        public double? Hr { get; set; }
        public double? Co2 { get; set; }
        public string UserCreate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? Tstamp { get; set; }
        public DateTime? Tstampdel { get; set; }
        public int? UserIdDel { get; set; }
        public bool? Bdel { get; set; }
        public double? Pinsp { get; set; }
        public double? O2 { get; set; }
        public double? Peep { get; set; }
        public double? Mv { get; set; }
        public double? Ibw { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientBlister
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? BlisterNum { get; set; }
        public int? BlisterKind { get; set; }
        public int? BlisterPlace { get; set; }
        public string BlisterSide { get; set; }
        public string BlisterPlaceDetails { get; set; }
        public string BlisterDateAppearOld { get; set; }
        public short? IsBlisterAppearInMahlaka { get; set; }
        public short? BlisterStatusId { get; set; }
        public string Comments { get; set; }
        public int? PrevBlisterId { get; set; }
        public int? UserIdcreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? BDel { get; set; }
        public string Idcard { get; set; }
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public short? RecStatus { get; set; }
        public string ParaDigPlace { get; set; }
        public DateTime? BlisterDateAppear { get; set; }
        public short? NConv { get; set; }
        public DateTime? DateCloseBlister { get; set; }
    }
}

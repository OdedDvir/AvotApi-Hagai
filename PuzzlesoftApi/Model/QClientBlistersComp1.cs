using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QClientBlistersComp1
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? BlisterNum { get; set; }
        public string BlisterSide { get; set; }
        public string BlisterPlaceDetails { get; set; }
        public DateTime? BlisterDateAppear { get; set; }
        public string IsBlisterAppearInMahlaka { get; set; }
        public string Comments { get; set; }
        public int? PrevBlisterId { get; set; }
        public DateTime? TStamp { get; set; }
        public string BlisterStatus { get; set; }
        public string BlisterPlace { get; set; }
        public short? BlisterStatusId { get; set; }
        public string UserCreate { get; set; }
        public bool? BDel { get; set; }
        public int? BlisterKind { get; set; }
        public string BlisterKindDesc { get; set; }
        public string BlisterLevel { get; set; }
        public DateTime? DateFolloeB { get; set; }
        public string Img1 { get; set; }
    }
}

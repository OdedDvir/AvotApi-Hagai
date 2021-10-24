using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class VTblclienttnuot
    {
        public int Id { get; set; }
        public int? TnuahId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Details { get; set; }
        public short? RecStatus { get; set; }
        public int? MosadIshpuzKod { get; set; }
        public int? DiurKindId { get; set; }
        public short? KodMahoz { get; set; }
        public int? TekenMita { get; set; }
        public short? AgafId { get; set; }
        public short? RoomId { get; set; }
        public short? BedNum { get; set; }
        public short? LeaveKindId { get; set; }
        public string Hospital { get; set; }
        public string HospitalMahlaka { get; set; }
        public DateTime? Date2 { get; set; }
        public int? UserIdcreate { get; set; }
        public string Results { get; set; }
        public int? SponserId { get; set; }
        public int? RoomIdold { get; set; }
        public short? BedNumOld { get; set; }
        public short? TifkudStatusId { get; set; }
        public short? MahlakaId { get; set; }
        public int? SponserIdold { get; set; }
        public byte? MahlakaIdold { get; set; }
        public bool? SingleInRoom { get; set; }
        public bool? BMahlakaNotChanged { get; set; }
        public int? SponserMahoz { get; set; }
        public string SponserService { get; set; }
        public string ArrivedFrom { get; set; }
        public string ChangeKind { get; set; }
        public string AllowDoctorTnuah { get; set; }
        public DateTime? TStamp { get; set; }
        public int? NConv { get; set; }
        public int? TnuahIdold { get; set; }
        public int? IshpuzNum { get; set; }
        public int? TifkudStatusIdOld { get; set; }
        public string Time1 { get; set; }
    }
}

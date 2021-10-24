using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QBedStatus
    {
        public int? ClientId { get; set; }
        public string Tnuah { get; set; }
        public DateTime? Date1 { get; set; }
        public int Id { get; set; }
        public int? TnuahId { get; set; }
        public string DiurKind { get; set; }
        public short? KodMahoz { get; set; }
        public int? TekenMita { get; set; }
        public int? DiurKindId { get; set; }
        public int? MosadIshpuzKod { get; set; }
        public string NameView { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Idcard { get; set; }
        public short? BedNum { get; set; }
        public short? RoomId { get; set; }
        public string AgafName { get; set; }
        public short? AgafId { get; set; }
        public string Mahlaka { get; set; }
        public short? SponserId { get; set; }
        public short? TifkudStatusId { get; set; }
        public short? MahlakaId { get; set; }
        public DateTime? Date2 { get; set; }
        public short? LeaveKindId { get; set; }
        public int? SponserIdold { get; set; }
        public short? LocationId { get; set; }
        public int? RoomIdold { get; set; }
        public string TifkudStatus { get; set; }
        public short? BedNumOld { get; set; }
        public bool? Archive { get; set; }
        public string RoomName { get; set; }
        public string RoomNameOld { get; set; }
        public string RoomClass { get; set; }
        public int? Kind1Id { get; set; }
        public byte? MahlakaIdold { get; set; }
        public string Details { get; set; }
        public string Hospital { get; set; }
        public string HospitalMahlaka { get; set; }
        public bool? SingleInRoom { get; set; }
        public short? MahlakaKindId { get; set; }
        public short? MainKind { get; set; }
    }
}

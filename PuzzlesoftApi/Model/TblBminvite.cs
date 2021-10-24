using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBminvite
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool? Urgent { get; set; }
        public DateTime? TStamp { get; set; }
        public string Bmid { get; set; }
        public bool? BConfirm { get; set; }
        public bool? NStatus { get; set; }
        public int? UserIdconfirm { get; set; }
        public string UserConfirm { get; set; }
        public DateTime? TStampConfirm { get; set; }
        public string Memo1 { get; set; }
        public DateTime? LastDateSee { get; set; }
        public DateTime? Date1 { get; set; }
        public string MiunCap { get; set; }
        public int? KabalaId { get; set; }
        public int? NumMacabi { get; set; }
        public bool SendToMacabi { get; set; }
        public string Animals { get; set; }
        public bool Abroad { get; set; }
        public string Diagnosis { get; set; }
        public string Comment { get; set; }
        public bool? Yn { get; set; }
        public string KodPlace { get; set; }
        public string KodDescPlace { get; set; }
        public bool BArchive { get; set; }
        public bool BDel { get; set; }
    }
}

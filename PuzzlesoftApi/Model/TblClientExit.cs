using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientExit
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date1 { get; set; }
        public string Time1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Time2 { get; set; }
        public string Target { get; set; }
        public int? TransferKindId { get; set; }
        public string LivuyName { get; set; }
        public decimal? LivuyPay { get; set; }
        public decimal? TransferPay { get; set; }
        public float Hours { get; set; }
        public string Comments { get; set; }
        public short? ExitReasonId { get; set; }
        public string HospitalKod { get; set; }
        public string UserName { get; set; }
        public string TimeAction { get; set; }
        public bool IsExitFuture { get; set; }
        public bool IsReturnFuture { get; set; }
        public bool? BDel { get; set; }
        public string GroupId { get; set; }
    }
}

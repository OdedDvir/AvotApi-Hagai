using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblvisitlistWeb
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int YomanId { get; set; }
        public DateTime Date1 { get; set; }
        public int UserIdCreate { get; set; }
        public int UserIdUpdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime TStampUpdate { get; set; }
        public bool BPayWorker { get; set; }
        public short StatusDone { get; set; }
        public string TimeArrive { get; set; }
        public bool BSentToSponser { get; set; }
        public decimal BSentToSponserSum { get; set; }
        public bool BShaban { get; set; }
        public bool BDoctor { get; set; }
        public string ParitKod { get; set; }
        public int PlainId { get; set; }
        public bool BDel { get; set; }
        public int TorTime { get; set; }
        public string Memo1 { get; set; }
        public int ChargesId { get; set; }
        public string MemoAction { get; set; }
        public int RelateId { get; set; }
        public bool BModeStandBy { get; set; }
        public int DocHeshId { get; set; }
        public bool BSentToWorker { get; set; }
        public decimal SentToWorkerSum { get; set; }
        public decimal SentToSponserSum { get; set; }
        public short TorKindId { get; set; }
        public bool BConv { get; set; }
        public short NColor { get; set; }
        public short BMarkDone { get; set; }
        public short MarkDone { get; set; }
        public byte StatusTor { get; set; }
        public bool BConfirmByCard { get; set; }
        public bool BNoReminder { get; set; }
        public int T17Ref { get; set; }
        public int WId { get; set; }
        public int MivId { get; set; }
        public int GroupId { get; set; }
        public bool BExport17 { get; set; }
        public int FreqId { get; set; }
        public short MarkDonebyMed { get; set; }
        public bool BConfirmByFree { get; set; }
        public short ReasonNoShowId { get; set; }
        public int TorTypeId { get; set; }
        public short StatusInc { get; set; }
        public short DisWorkerType { get; set; }
        public bool BSto { get; set; }
        public bool BSesia { get; set; }
        public int ManagerTorId { get; set; }
        public string GroupManagerTor { get; set; }
        public string Place { get; set; }
        public bool? BArrived { get; set; }
        public bool BNeedPay { get; set; }
        public bool BLocked { get; set; }
        public bool BSendSmsauto { get; set; }
        public bool BSendSms { get; set; }
        public string MemoManage { get; set; }
        public decimal Price1 { get; set; }
        public int MahlakaId1 { get; set; }
        public bool BFreq { get; set; }
        public string GroupTor { get; set; }
        public bool BHold { get; set; }
    }
}

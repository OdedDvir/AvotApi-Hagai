using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientEnterPay
    {
        public int ClientId { get; set; }
        public int? EnterStatusId { get; set; }
        public int? PayGroupId { get; set; }
        public short? DiscountPer { get; set; }
        public double? EnterSum { get; set; }
        public short? ShehikaMonths { get; set; }
        public short? ShehikaPer { get; set; }
        public bool? BPikadon { get; set; }
        public double? PikadonSum { get; set; }
        public DateTime? PikadonDate { get; set; }
        public short? HatsmadaId { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? DepartmentDate { get; set; }
        public double? MehironPrice { get; set; }
    }
}

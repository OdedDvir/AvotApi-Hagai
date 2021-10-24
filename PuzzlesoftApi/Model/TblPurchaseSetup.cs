using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblPurchaseSetup
    {
        public string BuyerName { get; set; }
        public int? BuyerId { get; set; }
        public string ComptrollerName { get; set; }
        public int? ComptrollerId { get; set; }
        public string AllowName { get; set; }
        public int? AllowId { get; set; }
        public string AllowHeshName { get; set; }
        public int? AllowHeshId { get; set; }
        public string PaymentName { get; set; }
        public int? PaymentId { get; set; }
        public bool? UpdateMelayByHeshDoc { get; set; }
    }
}

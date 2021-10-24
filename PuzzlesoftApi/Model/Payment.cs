using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Payment
    {
        public int? DocId { get; set; }
        public decimal? PaySum { get; set; }
        public DateTime? PayDate { get; set; }
        public short? PayMethod { get; set; }
        public string CheckId { get; set; }
        public int? Snif { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public string CreditKind { get; set; }
        public string CreditOwner { get; set; }
        public string ConfirmCreditNum { get; set; }
        public DateTime? CreditLastDate { get; set; }
        public int Id { get; set; }
        public bool? Active { get; set; }
        public int? ClientId { get; set; }
        public string Memo1 { get; set; }
        public bool? BMove { get; set; }
        public DateTime? MoveDate { get; set; }
        public int? BankId { get; set; }
        public int HafkadaId { get; set; }
        public bool BNoShowOnKupa { get; set; }

        public virtual TblHeshDocument Doc { get; set; }
    }
}

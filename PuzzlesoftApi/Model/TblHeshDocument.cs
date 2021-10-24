using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblHeshDocument
    {
        public TblHeshDocument()
        {
            Payments = new HashSet<Payment>();
            TblHeshDocItems = new HashSet<TblHeshDocItem>();
        }

        public int Id { get; set; }
        public int? DocNameId { get; set; }
        public string HeshKod { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? Asmachta { get; set; }
        public bool? Finished { get; set; }
        public float? PerDiscount { get; set; }
        public float? PerMaham { get; set; }
        public string Details { get; set; }
        public int? FolderId { get; set; }
        public string NimanName { get; set; }
        public int? Asmachta2Old { get; set; }
        public decimal? DocSum { get; set; }
        public bool? Active { get; set; }
        public int? ClientId { get; set; }
        public string NimanAddress { get; set; }
        public string DayarName { get; set; }
        public string DayarPlace { get; set; }
        public string UserCreate { get; set; }
        public bool? Printed { get; set; }
        public int? MahsanId { get; set; }
        public decimal? MahamSum { get; set; }
        public int? KodMiunId { get; set; }
        public bool? BIncome { get; set; }
        public string Month { get; set; }
        public bool? BPayed { get; set; }
        public int? MelayOutDest { get; set; }
        public int? MaintenanceRequestId { get; set; }
        public int? MahsanDestId { get; set; }
        public int? RelatedClientId { get; set; }
        public string OsekId { get; set; }
        public string ParitKod2 { get; set; }
        public bool? BPikadon { get; set; }
        public string Details2 { get; set; }
        public bool? BExport { get; set; }
        public int? OrderAsmachta { get; set; }
        public int? SapakDiscount { get; set; }
        public string DayarIdCard { get; set; }
        public string SapakOsekId { get; set; }
        public int? LocationId { get; set; }
        public string Asmachta2 { get; set; }
        public string Asmachta2ListId { get; set; }
        public string Asmachta3 { get; set; }
        public DateTime? DateSendByMail { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<TblHeshDocItem> TblHeshDocItems { get; set; }
    }
}

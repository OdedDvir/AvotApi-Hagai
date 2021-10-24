using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsContract
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? EntireDateByCon { get; set; }
        public int NumRoom { get; set; }
        public double PointsMadad { get; set; }
        public double Rate { get; set; }
        public string Comments { get; set; }
        public int MaslulId { get; set; }
        public double ChikaYear { get; set; }
        public int MaxHilut { get; set; }
        public int UserIdCreate { get; set; }
        public DateTime TStampCreate { get; set; }
        public string Involve1 { get; set; }
        public string Involve2 { get; set; }
        public double SumAll { get; set; }
        public short Type1 { get; set; }
        public DateTime? DateMadad { get; set; }
        public DateTime? DateRate { get; set; }
        public string Involve3 { get; set; }
        public string Involve4 { get; set; }
        public DateTime? DateHeskemZmaniS { get; set; }
        public DateTime? DateHeskemZmaniE { get; set; }
    }
}

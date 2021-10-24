using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblpritimWeb
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string ParitName { get; set; }
        public int SubjectId { get; set; }
        public short KindId { get; set; }
        public bool BArchive { get; set; }
        public short? NGroupLevel { get; set; }
        public string HeshKodIn { get; set; }
        public string Stbasic { get; set; }
        public string St1 { get; set; }
        public string St2 { get; set; }
        public int UserIdCreate { get; set; }
        public int UserIdUpdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime TStampUpdate { get; set; }
        public string DoctorKod { get; set; }
        public string MekParit { get; set; }
        public string Stm { get; set; }
        public int YomanTypeId { get; set; }
        public bool Bmaham { get; set; }
        public int Bbill { get; set; }
        public bool Archive { get; set; }
        public string FreeMaham { get; set; }
    }
}

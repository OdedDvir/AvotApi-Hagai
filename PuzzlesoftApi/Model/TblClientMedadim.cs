using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientMedadim
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateTime1 { get; set; }
        public DateTime? TStamp { get; set; }
        public string UserName { get; set; }
        public bool? BDel { get; set; }
        public int? MedicMeasurementId { get; set; }
        public int FormId { get; set; }

        public virtual TblMedadimBp TblMedadimBp { get; set; }
        public virtual TblMedadimBreathing TblMedadimBreathing { get; set; }
        public virtual TblMedadimEtco2 TblMedadimEtco2 { get; set; }
        public virtual TblMedadimFiver TblMedadimFiver { get; set; }
        public virtual TblMedadimMenstruation TblMedadimMenstruation { get; set; }
        public virtual TblMedadimPressB TblMedadimPressB { get; set; }
        public virtual TblMedadimPulse TblMedadimPulse { get; set; }
        public virtual TblMedadimSato TblMedadimSato { get; set; }
        public virtual TblMedadimSugar TblMedadimSugar { get; set; }
        public virtual TblMedadimTzoa TblMedadimTzoa { get; set; }
        public virtual TblMedadimUrine TblMedadimUrine { get; set; }
        public virtual TblMedadimWeight TblMedadimWeight { get; set; }
    }
}

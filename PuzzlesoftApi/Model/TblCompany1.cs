using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblCompany1
    {
        public int Id { get; set; }
        public string Name1 { get; set; }
        public int? LocationId { get; set; }
        public bool? BHideKupa { get; set; }
        public bool? BHideWait { get; set; }
        public string LblDoctorCap { get; set; }
        public string LblDoctorsCap { get; set; }
        public string LblClientCap { get; set; }
        public string LblClientsCap { get; set; }
        public string LblCardCap { get; set; }
        public bool? BArchive { get; set; }
        public bool? BClientPopup { get; set; }
        public int? NRefresh { get; set; }
        public int? NModeLookforOnStart { get; set; }
        public int? NModeLookForFreeTor { get; set; }
        public int? NModeShowDef { get; set; }
        public int? NModeCorrect { get; set; }
        public int? BModeMustTofes17 { get; set; }
        public string SPass { get; set; }
        public string CompanyStr { get; set; }
    }
}

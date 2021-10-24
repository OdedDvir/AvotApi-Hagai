using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblUserSetting
    {
        public int UserId { get; set; }
        public string ToolbarKeys { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }
        public int? CaptionColor { get; set; }
        public int? BgColor { get; set; }
        public int? TextColorList { get; set; }
        public int? TextColorForms { get; set; }
        public int? BgColorList { get; set; }
        public string UsersFields { get; set; }
        public string ClientsFields { get; set; }
        public string SapakimFields { get; set; }
        public string OthersFields { get; set; }
        public string UsersSize { get; set; }
        public string ClientsSize { get; set; }
        public string SapakimSize { get; set; }
        public string OthersSize { get; set; }
        public string Harshah { get; set; }
        public string ClientsFieldsHeader { get; set; }
        public short? EnterScreenId { get; set; }
        public string Mahlaka { get; set; }
        public int? LastInfoId { get; set; }
        public string UserLocations { get; set; }
        public string UserLocationId { get; set; }
        public bool? BMahlakaOnly { get; set; }
        public int? SponserIdOnly { get; set; }
        public int KupaIdonly { get; set; }
        public string MahlakaReminder { get; set; }
        public string SelectIdKupaOrSponser { get; set; }
        public bool BMustStrongPassword { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFunctionalGuideDetailClient
    {
        public int Id { get; set; }
        public int MainId { get; set; }
        public int MobilePhizioId { get; set; }
        public string MobileConduciveListId { get; set; }
        public string MobileConduciveList { get; set; }
        public string MobilePhizioComment { get; set; }
        public int CrossingHelpId { get; set; }
        public int CrossingSideId { get; set; }
        public int CrossingConduciveId { get; set; }
        public string CrossingPhizioComment { get; set; }
        public int BedFunctionId { get; set; }
        public int ChangePosition { get; set; }
        public string BedFunctionComment { get; set; }
        public string EquipmentPhizioListId { get; set; }
        public string EquipmentPhizioList { get; set; }
        public string EquipmentPhizioComment { get; set; }
        public string PhizioOtherListId { get; set; }
        public string PhizioOtherList { get; set; }
        public string PhizioOtherComment { get; set; }
        public int TopClothesId { get; set; }
        public string TopClothesComment { get; set; }
        public int LowerClothesId { get; set; }
        public string LowerClothesComment { get; set; }
        public string SplintsSlingsListId { get; set; }
        public string SplintsSlingsList { get; set; }
        public string SplintsSlingsComment { get; set; }
        public string HearingAidListId { get; set; }
        public string HearingAidList { get; set; }
        public int HearingLevelId { get; set; }
        public string HearingComment { get; set; }
        public string CommunicationAidListId { get; set; }
        public string CommunicationAidList { get; set; }
        public string CommunicationAidComment { get; set; }
        public string MainLang { get; set; }
        public int TeethId { get; set; }
        public string Teethcomment { get; set; }
        public int DrinkId { get; set; }
        public string DrinkComment { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class MedicinesTemp
    {
        public string DrugKod { get; set; }
        public string TradeNameShort { get; set; }
        public string TradeName { get; set; }
        public string DrugGroup { get; set; }
        public int? NumOnPac { get; set; }
        public short? SalBriyut { get; set; }
        public int? PharmaKod { get; set; }
        public string PharmaDescription { get; set; }
        public int? TipuliKod { get; set; }
        public string TipuliDescription { get; set; }
        public string DrugMirshamKind { get; set; }
        public bool? CheckInteraction { get; set; }
        public short? Need29g { get; set; }
        public short? CanBreakTab { get; set; }
        public int? Genric1Kod { get; set; }
        public string Genric1Desc { get; set; }
        public float? MinunNum { get; set; }
        public string MinunType { get; set; }
        public float? MinunNum2 { get; set; }
        public string MinunType2 { get; set; }
        public int? Genric2Kod { get; set; }
        public string Genric2Desc { get; set; }
        public float? Genric2Quantity { get; set; }
        public string Genric2Unit { get; set; }
        public int? Genric3Kod { get; set; }
        public string Genric3Desc { get; set; }
        public float? Genric3Quantity { get; set; }
        public string Genric3Unit { get; set; }
        public float? TotalMinunNum { get; set; }
        public bool? CheckRegishut { get; set; }
        public int? RegishutKind { get; set; }
        public short? RegishutPriority { get; set; }
        public string RegishutMsg { get; set; }
        public bool? ShowMirshamInTrade { get; set; }
        public short? NeedMirsham { get; set; }
        public short MaccabiDolars { get; set; }
        public int? DrugFormatKod { get; set; }
        public string DrugFormat { get; set; }
        public short? GenricPriority { get; set; }
        public string MelayKod { get; set; }
        public bool? BSal { get; set; }
        public bool? BNeedAllow { get; set; }
        public float? NumToInvite { get; set; }
        public int? MiunId { get; set; }
        public string HorimKod { get; set; }
        public string Comments { get; set; }
        public bool? ClalitSal { get; set; }
        public bool? LeumitSal { get; set; }
        public bool? MeuhedetSal { get; set; }
        public bool? MacabiSal { get; set; }
        public bool? BInviteFromSapak { get; set; }
        public bool? BNotShowInMirsham { get; set; }
        public short? DrugPerStrong { get; set; }
        public bool? BNotShowInCradex { get; set; }
        public bool? SaleAsPack { get; set; }
        public int Id { get; set; }
        public int? GenricGroupKod { get; set; }
        public int? PharmaGroupKod { get; set; }
        public bool? BManual { get; set; }
        public bool Archive { get; set; }
        public int LocalDolars { get; set; }
        public bool PainDrug { get; set; }
        public string GvKod { get; set; }
        public string DrugOrders { get; set; }
        public bool? BToNurse { get; set; }
        public int? FoodId { get; set; }
        public string MelaykodOld { get; set; }
        public string Drugkodold { get; set; }
        public DateTime? PriceUpdateDate { get; set; }
        public string PriceUpdateUser { get; set; }
        public string PriceComments { get; set; }
        public string TradeNameOld { get; set; }
    }
}

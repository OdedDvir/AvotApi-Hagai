﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class ClientDetail
    {
        public ClientDetail()
        {
            Appointments = new HashSet<Appointment>();
            ClientDocs = new HashSet<ClientDoc>();
            ContactMen = new HashSet<ContactMan>();
            TblClientGuardians = new HashSet<TblClientGuardian>();
            TblClientsForms = new HashSet<TblClientsForm>();
            TblWorkerRooms = new HashSet<TblWorkerRoom>();
        }

        public int Id { get; set; }
        public string OsekId { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string NameView { get; set; }
        public string Meaaged { get; set; }
        public short? ToaarId { get; set; }
        public int? SochenId { get; set; }
        public int? Kind1Id { get; set; }
        public int? Kind2Id { get; set; }
        public string Company { get; set; }
        public short? JobId { get; set; }
        public string Idcard { get; set; }
        public string Street { get; set; }
        public int? CityId { get; set; }
        public string Zip { get; set; }
        public string MailBox { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        /*public string EmailInbox { get; set; }
        public string EmailSent { get; set; }*/
        public bool? Archive { get; set; }
        public string Password { get; set; }
        public string Comments { get; set; }
        public string Details { get; set; }
        /*public string PersonImage { get; set; }
        public short? MainKind { get; set; }
        public string WebSite { get; set; }
        public string Kod { get; set; }
        public int? GroupKod { get; set; }
        public bool? Maham { get; set; }
        public bool? HarshahManager { get; set; }
        public short? BankId { get; set; }
        public short? CardKindId { get; set; }
        public short? PayLimitId { get; set; }*/
        public string Account { get; set; }
        public string Snif { get; set; }/*
        public string CardNum { get; set; }
        public string CardDate { get; set; }
        public int? GoremMafneId { get; set; }
        public decimal? MaxAshray { get; set; }
        public int? HachnasaFolder { get; set; }
        public float? PerNikuyMakor { get; set; }
        public DateTime? DateNikuyMakor { get; set; }
        public int? AverageLateness { get; set; }*/
        public short? Gender { get; set; }
        //public short? FamilyStatus { get; set; }
        public short? Childs { get; set; }
        //public string EnglishName { get; set; }
        //public int? UserId { get; set; }
        public DateTime? Birthday { get; set; }
        /*public int? BirthCountryId { get; set; }
        public string FatherName { get; set; }
        public short? KupaId { get; set; }
        public short? BituahId { get; set; }
        public string AliaYear { get; set; }
        public short? LanguageId { get; set; }
        public bool? IsMabar { get; set; }
        public string MotherName { get; set; }
        public string KupaDoctor { get; set; }
        public short? OptNiman { get; set; }
        public DateTime? KabalaDate { get; set; }
        public bool? IsMasav { get; set; }
        public string NimanName { get; set; }
        public string NimanAddress { get; set; }
        public bool? NotCharged { get; set; }
        public int? TnuahId { get; set; }
        public bool? AutoMirsham { get; set; }*/
        public string Harshah { get; set; }
        /*public bool? IsUser { get; set; }
        public int? RoomId { get; set; }
        public short? BedNum { get; set; }
        public string MyListUsers { get; set; }
        public string DayarPhone { get; set; }*/
        public int? Interkum { get; set; }
        /*public string SidurPtira { get; set; }
        public string Tsavah { get; set; }*/
        public int? Idnum { get; set; }
        public string Ext { get; set; }
        /*public int? KupaSnifId { get; set; }
        public string Properties { get; set; }
        public bool? BSakeret { get; set; }
        public int? RelatedClient { get; set; }
        public decimal? PriceEnter { get; set; }
        public decimal? PriceBack { get; set; }
        public DateTime? DateNeedEnter { get; set; }
        public int? MainContactManId { get; set; }
        public string ArnonaProperties { get; set; }
        public float? ArnonaPerDiscount { get; set; }
        public short? LocationId { get; set; }
        public DateTime? DateFirst { get; set; }
        public short? WorkerJobPer { get; set; }
        public DateTime? WorkerJobStart { get; set; }
        public string Languages { get; set; }
        public string CarNum { get; set; }
        public string CarDetails { get; set; }
        public string BmwebUserName { get; set; }
        public string BmwebPassword { get; set; }
        public string BmwebKupa { get; set; }
        public decimal? WorkerHourPrice { get; set; }
        public decimal? WorkerNesiotPrice { get; set; }
        public string KodHilut { get; set; }
        public bool? IsContactMenShared { get; set; }
        public short? MasavDay { get; set; }
        public string B2bCity { get; set; }*/
        public string City { get; set; }
        /*public string TransferalComments { get; set; }
        public DateTime? WorkerJobEnd { get; set; }
        public short? MedicalGroupId { get; set; }
        public string UserPassport { get; set; }
        public string RelatedName { get; set; }
        public int? MasavIdCard { get; set; }
        public int? MarketingSponserId { get; set; }
        public int? MarketingTifkudStatusId { get; set; }
        public string RelatedNameIdcard { get; set; }
        public DateTime? RelatedNameBday { get; set; }
        public string RelatedNameWorkJob { get; set; }
        public string RelatedNameBcountry { get; set; }
        public string ArmyLevel { get; set; }
        public string ArmyId { get; set; }
        public int? SponserId { get; set; }*/
        public string Hospital { get; set; }
        /*public string LicenseId { get; set; }
        public int? ResponsibleId { get; set; }
        public string MedMemo { get; set; }
        public string MedProp { get; set; }
        public DateTime? WriteLastDate { get; set; }
        public string TransferalAddings { get; set; }
        public int? NConv { get; set; }
        public short? HospitalTransferId { get; set; }*/
        public string WorkerUserName { get; set; }
        public int? UserProfileId { get; set; }
        /*public string GuardianName { get; set; }
        public string GuardianField { get; set; }
        public string WorkerRoomId { get; set; }
        public string WorkerRoomJobId { get; set; }
        public string KupaSnif { get; set; }
        public bool? BPassport { get; set; }
        public DateTime? ExitForecast { get; set; }
        public int? SapakDiscount { get; set; }
        public bool BYoman { get; set; }
        public bool? IsShotefPay { get; set; }
        public int? ShotefDays { get; set; }
        public string Kvura { get; set; }
        public string CurrentStatus { get; set; }
        public string ClientKod2 { get; set; }*/
        public string Phone4 { get; set; }
        /*public bool? BArchiveGroup { get; set; }
        public string ElectricityCredit { get; set; }
        public int? ReligionId { get; set; }
        public string MailToHesh { get; set; }
        public double WaterGardenCredit { get; set; }
        public double WaterHomeCredit { get; set; }
        public short DocFile { get; set; }
        public string ElectricityCreditPrice { get; set; }
        public string WaterCredit { get; set; }
        public string WaterCreditPrice { get; set; }*/
        //public bool? Collectbymiun { get; set; }
        //public bool? HeshCollectbymiun { get; set; }
        //public bool? HeshCollectSame { get; set; }
        //public int? HeshCollectBy { get; set; }
        //public int? TypeHeshCollectBy { get; set; }
        /*public string EducationF { get; set; }
        public string YearsOfEducation { get; set; }
        public string SponserKod { get; set; }
        public DateTime? LastUpdatePassword { get; set; }
        public bool BBlockedUser { get; set; }
        public int AtdId { get; set; }
        public bool? BCompany { get; set; }
        //public string PrioId { get; set; }
        //public string PrioId2 { get; set; }
        public string FnameEng { get; set; }
        public string LnameEng { get; set; }
        public string IdCardImage { get; set; }*/

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ClientDoc> ClientDocs { get; set; }
        public virtual ICollection<ContactMan> ContactMen { get; set; }
        public virtual ICollection<TblClientGuardian> TblClientGuardians { get; set; }
        public virtual ICollection<TblClientsForm> TblClientsForms { get; set; }
        public virtual ICollection<TblWorkerRoom> TblWorkerRooms { get; set; }

        public string GetPhoneNumber()
        {
            return Phone1.Coalesce(Phone2, Phone3, Phone4);
        }
    }
}

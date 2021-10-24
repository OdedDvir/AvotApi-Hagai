using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QRoomDetail
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Maslul { get; set; }
        public string KeyKind { get; set; }
        public string Symbole { get; set; }
        public int? Kind1Id { get; set; }
        public int? Kind2Id { get; set; }
        public int? BGander { get; set; }
        public string MivneKind { get; set; }
        public int? SuppervisionId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? StartDate { get; set; }
        public string Street { get; set; }
        public int? AddressNum { get; set; }
        public string Neighbor { get; set; }
        public string CityName { get; set; }
        public int? City { get; set; }
        public string Phone { get; set; }
        public int? GanArea { get; set; }
        public int? KiurNum { get; set; }
        public int? ToiletNums { get; set; }
        public int? KidsNum { get; set; }
        public int? YardSize { get; set; }
        public string PersonalEval { get; set; }
        public string GeneralState { get; set; }
        public string GannenetName { get; set; }
        public int? GannenetId { get; set; }
        public string GannenetPhone { get; set; }
        public string GannenetPhone2 { get; set; }
        public string Suppervision { get; set; }
        public string AssistantName { get; set; }
        public int? AssistantId { get; set; }
        public string AssistantPhone { get; set; }
        public string RoomName { get; set; }
        public string AgafName { get; set; }
        public string InnerNum { get; set; }
        public string AssistantFreeDays { get; set; }
        public string GannenetFreeDays { get; set; }
        public string Storage { get; set; }
        public string YardState { get; set; }
        public short? MedicalGroupId { get; set; }
    }
}

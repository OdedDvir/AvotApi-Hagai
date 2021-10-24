using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRoomsDetail
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public string Maslul { get; set; }
        public string KeyKind { get; set; }
        public string InnerNum { get; set; }
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
        public string City { get; set; }
        public string Phone { get; set; }
        public int? GanArea { get; set; }
        public int? KiurNum { get; set; }
        public int? ToiletNums { get; set; }
        public int? KidsNum { get; set; }
        public int? YardSize { get; set; }
        public string PersonalEval { get; set; }
        public string GeneralState { get; set; }
        public string Storage { get; set; }
        public string YardState { get; set; }
    }
}

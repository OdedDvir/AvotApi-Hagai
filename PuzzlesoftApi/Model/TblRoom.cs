using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRoom
    {
        public TblRoom()
        {
            FormMarketings = new HashSet<FormMarketing>();
        }

        public int Id { get; set; }
        public int? AgafId { get; set; }
        public string RoomName { get; set; }
        public short? BedsNum { get; set; }
        public string Comments { get; set; }
        public string RoomDefs { get; set; }
        public short? NObj { get; set; }
        public string RoomPrice { get; set; }
        public string RoomSize { get; set; }
        public string RoomNum { get; set; }
        public string RoomClass { get; set; }
        public bool? AirCond { get; set; }
        public short? MahlakaId { get; set; }
        public short? Teken { get; set; }
        public bool? Archive { get; set; }
        public int OwnerId { get; set; }
        public int MaslulId { get; set; }
        public string OwnerDetails { get; set; }
        public int? QuantityId { get; set; }
        public string QuantityName { get; set; }
        public string ZmidId { get; set; }
        public string ZmidName { get; set; }
        public string PropId { get; set; }
        public string PropName { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public string DefdirectionId { get; set; }
        public string DefdirectionName { get; set; }
        public double? AreaZ { get; set; }
        public double? AreaArn { get; set; }
        public double? AreaNot { get; set; }
        public string Comment { get; set; }

        public virtual TblAgaf Agaf { get; set; }
        public virtual ICollection<FormMarketing> FormMarketings { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblListPriceShehium
    {
        public int Id { get; set; }
        public string ShehiaCap { get; set; }
        public string ZugOne { get; set; }
        public int? ClassId { get; set; }
        public string RoomClass { get; set; }
        public double? Price1 { get; set; }
        public double? Price2 { get; set; }
        public string Extra { get; set; }
        public short? RoomMin { get; set; }
        public short? RoomMax { get; set; }
        public string StatusTifkud { get; set; }
        public short? LocationId { get; set; }
        public string Key1 { get; set; }
        public short? TifkudStatusId { get; set; }
        public short? DiurKind { get; set; }
    }
}

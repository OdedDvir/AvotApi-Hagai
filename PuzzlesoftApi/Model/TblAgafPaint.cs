using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAgafPaint
    {
        public int? RoomId { get; set; }
        public short? NObj { get; set; }
        public float? Top1 { get; set; }
        public float? Left1 { get; set; }
        public float? Width1 { get; set; }
        public float? Height1 { get; set; }
        public int? AgafId { get; set; }
        public int? NColor { get; set; }
        public string ImgKey { get; set; }

        public virtual TblRoom Room { get; set; }
    }
}

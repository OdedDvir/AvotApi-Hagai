using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblAgaf
    {
        public TblAgaf()
        {
            FormMarketings = new HashSet<FormMarketing>();
            TblRooms = new HashSet<TblRoom>();
        }

        public string AgafName { get; set; }
        public int Id { get; set; }
        public short? NKind { get; set; }
        public short? AgafKind { get; set; }
        public short? LocationId { get; set; }
        public string PicPath { get; set; }
        public bool? BRoomFrame { get; set; }

        public virtual ICollection<FormMarketing> FormMarketings { get; set; }
        public virtual ICollection<TblRoom> TblRooms { get; set; }
    }
}

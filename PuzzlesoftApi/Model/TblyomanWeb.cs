using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblyomanWeb
    {
        public int Id { get; set; }
        public string YomanName { get; set; }
        public int WorkerId { get; set; }
        public string Room { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public bool BSpec { get; set; }
        public int LocationId { get; set; }
        public int UserIdCreate { get; set; }
        public int UserIdUpdate { get; set; }
        public DateTime TStampCreate { get; set; }
        public DateTime TStampUpdate { get; set; }
        public int RangeInYoman { get; set; }
        public bool AllowChangeTime { get; set; }
        public int NW { get; set; }
        public int NH { get; set; }
        public string YomanMin { get; set; }
        public string YomanMax { get; set; }
        public bool Archive { get; set; }
        public int YomanClassId { get; set; }
        public string UniqeYoman { get; set; }
    }
}

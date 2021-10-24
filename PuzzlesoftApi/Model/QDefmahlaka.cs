using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QDefmahlaka
    {
        public string Item { get; set; }
        public short Id { get; set; }
        public short? MabarId { get; set; }
        public bool? Active { get; set; }
        public short? MitotTeken { get; set; }
        public short? MahlakaKindId { get; set; }
        public byte? Locationid { get; set; }
        public int? DefaultRoomId { get; set; }
        public string Workers { get; set; }
        public int? MacKod { get; set; }
        public string MabarId2 { get; set; }
        public string RefueeManager { get; set; }
        public string MainNurse { get; set; }
        public string MahlakaManager { get; set; }
        public bool? CarsexSign { get; set; }
        public string Phone { get; set; }
        public string MabarKod { get; set; }
    }
}

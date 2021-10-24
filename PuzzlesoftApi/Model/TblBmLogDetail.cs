using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblBmLogDetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ClientId { get; set; }
        public string ErrorMsg { get; set; }
        public string BmKey { get; set; }
        public short? NType { get; set; }
        public string IdCard { get; set; }
        public string Bmid { get; set; }
        public int? RelatedId { get; set; }
    }
}

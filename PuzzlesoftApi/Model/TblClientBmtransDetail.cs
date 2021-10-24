using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientBmtransDetail
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public int? FormId { get; set; }
        public string Name1 { get; set; }
        public string Bmid { get; set; }
        public string BmbarCode { get; set; }
        public bool? BDone { get; set; }
        public int? StatusId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientFormDetailA3
    {
        public int? ClientFormId { get; set; }
        public string ClsName { get; set; }
        public bool? FieldA { get; set; }
        public string FieldB { get; set; }
        public string FieldC { get; set; }
        public int Id { get; set; }
        public string Memo1 { get; set; }
        public bool? BDel { get; set; }
        public int? NConv { get; set; }

        public virtual TblClientsForm ClientForm { get; set; }
    }
}

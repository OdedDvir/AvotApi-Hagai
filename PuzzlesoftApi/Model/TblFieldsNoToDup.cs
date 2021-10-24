using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFieldsNoToDup
    {
        public int Id { get; set; }
        public long? FormTypeId { get; set; }
        public string ClsName { get; set; }
        public string DefaultVal { get; set; }
    }
}

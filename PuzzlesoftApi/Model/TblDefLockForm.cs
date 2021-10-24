using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDefLockForm
    {
        public int Id { get; set; }
        public int? TypeFormId { get; set; }
        public string FormName { get; set; }
        public int? DaysLock { get; set; }
    }
}

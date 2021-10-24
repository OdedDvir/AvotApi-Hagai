using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormsPermission
    {
        public int Id { get; set; }
        public string FormKey { get; set; }
        public int FormType { get; set; }
        public string PermissionKey { get; set; }
        public bool BOpen { get; set; }
        public bool BWrite { get; set; }
        public bool BLock { get; set; }
        public bool? BRead { get; set; }
    }
}

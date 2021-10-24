using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public short? RoleType { get; set; }
        public string RoleTreeSrc { get; set; }
        public string RoleDecription { get; set; }
        public short? RoleCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblRolesDetail
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string RoleRtf { get; set; }
        public string RolePictures { get; set; }
        public string RoleVideos { get; set; }
        public string RolesDoc { get; set; }
    }
}

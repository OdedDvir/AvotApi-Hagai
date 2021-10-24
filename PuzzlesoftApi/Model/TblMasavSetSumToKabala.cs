using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMasavSetSumToKabala
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public int UserId { get; set; }
        public decimal Sum1 { get; set; }
        public int MimId { get; set; }
    }
}

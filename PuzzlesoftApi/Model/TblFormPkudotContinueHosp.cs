using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFormPkudotContinueHosp
    {
        public int Id { get; set; }
        public int DrugId { get; set; }
        public int ClientId { get; set; }
        public bool BConHosp { get; set; }
    }
}

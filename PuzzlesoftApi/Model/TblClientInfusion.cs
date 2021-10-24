using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientInfusion
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public string SolName { get; set; }
        public int? SolSize { get; set; }
        public int? SolGive { get; set; }
        public int? SubjectId { get; set; }
        public bool? BDel { get; set; }
        public string GiveWay { get; set; }
        public int? RowId { get; set; }

        public virtual TblClientMedadim Row { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientsForm
    {
        public TblClientsForm()
        {
            TblClientFormDetailA3s = new HashSet<TblClientFormDetailA3>();
        }

        public int Id { get; set; }
        public int? TypFormId { get; set; }
        public int? UserIdcreate { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserIdLocked { get; set; }
        public DateTime? DateLocked { get; set; }
        public int? ToClientId { get; set; }
        public int? DPoint { get; set; }
        public bool? Locked { get; set; }
        public string ToGroup { get; set; }
        public int? TypFormId2 { get; set; }
        public bool? BDel { get; set; }
        public DateTime? TscreateDate { get; set; }
        public int? NConv { get; set; }
        public bool BKabala { get; set; }
        public string GroupKey { get; set; }
        public int ParentId { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public bool SendForm { get; set; }
        public int? RelatedFormId { get; set; }
        public int? KabalaId { get; set; }
        public bool Bsend { get; set; }

        public virtual ClientDetail ToClient { get; set; }
        public virtual ICollection<TblClientFormDetailA3> TblClientFormDetailA3s { get; set; }
    }
}

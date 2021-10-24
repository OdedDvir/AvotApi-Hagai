using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblMirshamDetail
    {
        public int? MirshamId { get; set; }
        public string DrugName { get; set; }
        public string Minun { get; set; }
        public string Capsule { get; set; }
        public short? Monthly { get; set; }
        public float? Num1 { get; set; }
        public string SalBriyut { get; set; }
        public string MelayRest { get; set; }
        public string TypeToInvite { get; set; }
        public string LastAmount { get; set; }
        public bool Added { get; set; }
        public int Id { get; set; }
        public string DrugComment { get; set; }
        public string DrugComments { get; set; }
        public int? Numday { get; set; }
        public int DrugId { get; set; }

        public virtual TblMirshamim Mirsham { get; set; }
    }
}

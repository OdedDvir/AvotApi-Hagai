using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClinicalCondition
    {
        public int Id { get; set; }
        public string Avhana { get; set; }
        public string Condition { get; set; }
        public string DrugName { get; set; }
        public string TipulName { get; set; }
        public string Comment { get; set; }
    }
}

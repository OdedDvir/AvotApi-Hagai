using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QRepTipulPlan
    {
        public DateTime? תאריךהתחלה { get; set; }
        public int? ClientId { get; set; }
        public string סוגטיפול { get; set; }
        public string סיבתהטיפול { get; set; }
        public string הערכה { get; set; }
        public DateTime? תאריךסיום { get; set; }
        public bool? TipulIn { get; set; }
    }
}

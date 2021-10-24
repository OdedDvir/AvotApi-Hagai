using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblDoctor
    {
        public string שםהטיפול { get; set; }
        public string קטגוריה { get; set; }
        public string תיאורהטיפול { get; set; }
        public DateTime? תאריך { get; set; }
        public DateTime? שעתביצוע { get; set; }
        public string זמניטיפולבפועל { get; set; }
        public string שםמשפחה { get; set; }
        public string שםפרטי { get; set; }
        public double? מזההמערכת { get; set; }
        public string מטפל { get; set; }
        public DateTime? תאריךסיוםביצוע { get; set; }
        public string רישוםסיוםביצוע { get; set; }
    }
}

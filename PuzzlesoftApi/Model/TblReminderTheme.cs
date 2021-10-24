using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblReminderTheme
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public string ModuleName { get; set; }
        public string Item { get; set; }
        public int? TimeBefore { get; set; }
        public string TimeKind { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblReminderModule
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string ReminderMode { get; set; }
        public string Cap1 { get; set; }
        public double? ReminderDelay { get; set; }
        public int? ReminderTime { get; set; }
        public int? RecurrenceDays { get; set; }
        public string Caption { get; set; }
    }
}

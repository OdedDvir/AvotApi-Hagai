using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QAppointcheck
    {
        public DateTime? AppointDate { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public int? UserId { get; set; }
        public int Id { get; set; }
        public string CompleteSign { get; set; }
        public string AppointWith { get; set; }
        public bool? Complete { get; set; }
        public short? OptKind { get; set; }
        public string TheKind { get; set; }
        public string Responsible { get; set; }
        public string AppointAddress { get; set; }
        public int? ClientId { get; set; }
        public short? UserIdcreate { get; set; }
        public string UserCreate { get; set; }
        public short? ReminderBefore { get; set; }
        public bool? ActionPassed { get; set; }
        public string AppointTheme { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Appointment
    {
        public short? OptKind { get; set; }
        public int? ResponsibleId { get; set; }
        public string AppointPhone { get; set; }
        public string AppointWith { get; set; }
        public string AppointAddress { get; set; }
        public DateTime? AppointDate { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public short? ReminderBefore { get; set; }
        public bool? ReminderOn { get; set; }
        public bool? Old { get; set; }
        public bool? Outlook { get; set; }
        public string SoundPath { get; set; }
        public int? Frequency { get; set; }
        public string AppointTheme { get; set; }
        public string Details { get; set; }
        public int? ClientId { get; set; }
        public int Id { get; set; }
        public int? UserId { get; set; }
        public short? UserIdcreate { get; set; }
        public int? UserIdreminder { get; set; }
        public bool? Complete { get; set; }
        public bool? ActionPassed { get; set; }
        public int? PalmId { get; set; }
        public DateTime? SynTime { get; set; }
        public short? RecurrenceType { get; set; }
        public int? RecurrenceId { get; set; }
        public string RecurrenceStart { get; set; }
        public string RecurrenceEnd { get; set; }
        public int? NColor { get; set; }
        public int? ShareId { get; set; }
        public short? ShareStep { get; set; }
        public short? RecurrenceDay { get; set; }

        public virtual ClientDetail Client { get; set; }
    }
}

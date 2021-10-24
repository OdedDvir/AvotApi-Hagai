using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Task
    {
        public Task()
        {
            Task2s = new HashSet<Task2>();
        }

        public string Phone { get; set; }
        public string Place { get; set; }
        public DateTime? Date1 { get; set; }
        public string Time1 { get; set; }
        public short? Return { get; set; }
        public bool? Outlook { get; set; }
        public string SoundPath { get; set; }
        public string Frequency { get; set; }
        public string TaskTheme { get; set; }
        public DateTime? StartDate { get; set; }
        public string DayFrequency { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? Date2 { get; set; }
        public string Time2 { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? ReminderOn { get; set; }
        public string Comments { get; set; }
        public int? ClientId { get; set; }
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? UserIdcreate { get; set; }
        public int? UserIdreminder { get; set; }
        public int? StatusId { get; set; }
        public bool? Main { get; set; }
        public int? PalmId { get; set; }
        public DateTime? SynTime { get; set; }
        public short? Priority { get; set; }

        public virtual ICollection<Task2> Task2s { get; set; }
    }
}

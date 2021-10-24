using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Task2
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? ResponsibleId { get; set; }
        public string Place { get; set; }
        public string TaskTheme { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime? LastDate { get; set; }
        public string LastTime { get; set; }
        public int? StatusId { get; set; }
        public short? Per { get; set; }
        public string Description { get; set; }
        public DateTime? RemDate { get; set; }
        public string RemTime { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? ReminderOn { get; set; }
        public string SoundPath { get; set; }
        public bool? Main { get; set; }

        public virtual Task Task { get; set; }
    }
}

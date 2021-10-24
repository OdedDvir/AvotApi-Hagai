using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Tasks1
    {
        public string NameView { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? ReminderOn { get; set; }
        public int Id { get; set; }
        public string StatusSign { get; set; }
        public int? UserId { get; set; }
        public int? Kind1Id { get; set; }
        public int? UserIdcreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? ClientId { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public bool? Main { get; set; }
        public string TaskTheme { get; set; }
    }
}

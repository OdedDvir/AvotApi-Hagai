using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QTasks2
    {
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string TaskTheme { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastDate { get; set; }
        public int Id { get; set; }
        public string Responsible { get; set; }
        public int? TaskId { get; set; }
        public int? ResponsibleId { get; set; }
        public int? StatusId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string UserCreate { get; set; }
        public string NameView { get; set; }
        public string Phone { get; set; }
        public bool? Main { get; set; }
        public int? UserIdcreate { get; set; }
        public string Place { get; set; }
    }
}

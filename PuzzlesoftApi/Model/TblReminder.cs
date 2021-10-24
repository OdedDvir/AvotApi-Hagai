using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblReminder
    {
        public int Id { get; set; }
        public DateTime? ReminderDate { get; set; }
        public string Theme { get; set; }
        public string Place { get; set; }
        public string NameView { get; set; }
        public string SoundPath { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public bool? ReminderOn { get; set; }
        public int? ActionId { get; set; }
        public string FormName { get; set; }
        public short? Status { get; set; }
        public int? UserIdcreate { get; set; }
        public string MessageKey { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public int? Clientid { get; set; }
        public int? RecurrenceDays { get; set; }
        public DateTime? ReminderDateCreate { get; set; }
        public DateTime? TStamp { get; set; }
        public bool? UserId { get; set; }
        public DateTime? ReminderDateReceive { get; set; }
        public int? ByLocation { get; set; }
        public bool? Archive { get; set; }
    }
}

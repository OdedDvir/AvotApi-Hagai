using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Message
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SenderId { get; set; }
        public int? MsgToId { get; set; }
        public string MessageTo { get; set; }
        public string MessageFrom { get; set; }
        public DateTime? MessageDate { get; set; }
        public bool? GotMessage { get; set; }
        public string Request { get; set; }
        public string Answer { get; set; }
        public bool? AddToOutlook { get; set; }
        public int? Task2Id { get; set; }
        public short? Status { get; set; }
        public short? NType { get; set; }
    }
}

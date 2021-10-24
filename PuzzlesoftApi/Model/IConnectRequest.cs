using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class IConnectRequest
    {
        public int Id { get; set; }
        public string שםיועץ { get; set; }
        public string מחוז { get; set; }
        public string מרפאה { get; set; }
        public string תחום { get; set; }
        public bool Sla { get; set; }
        public string הפניה { get; set; }
        public string סטאטוס { get; set; }
        public DateTime? תאריךפניה { get; set; }
    }
}

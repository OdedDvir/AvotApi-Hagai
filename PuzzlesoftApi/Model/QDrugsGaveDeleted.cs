using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class QDrugsGaveDeleted
    {
        public int Id { get; set; }
        public string NameView { get; set; }
        public string DateDrug { get; set; }
        public int Type { get; set; }
        public string TimeDrug { get; set; }
        public DateTime? Dd { get; set; }
        public string DateSign { get; set; }
        public string TimeSign { get; set; }
        public string DrugDetails { get; set; }
        public int ClientId { get; set; }
        public string DrugMinun { get; set; }
    }
}

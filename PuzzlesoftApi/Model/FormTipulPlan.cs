using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FormTipulPlan
    {
        public int Id { get; set; }
        public DateTime? Date1 { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public short? RecStatus { get; set; }
        public string Theme { get; set; }
        public string Target { get; set; }
        public string Siudi { get; set; }
        public string Estimation { get; set; }
    }
}

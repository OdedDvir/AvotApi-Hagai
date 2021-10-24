using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class Emp
    {
        public decimal EmpsId { get; set; }
        public string EmpsName { get; set; }
        public decimal? EmpsSalary { get; set; }
        public DateTime? EmpsDate { get; set; }
    }
}

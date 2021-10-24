using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblCourseActivity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int GuideId { get; set; }
        public string ActivitySummary { get; set; }
        public DateTime Date1 { get; set; }
        public bool BDel { get; set; }
    }
}

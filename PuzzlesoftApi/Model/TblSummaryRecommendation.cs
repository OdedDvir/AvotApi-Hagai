using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblSummaryRecommendation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FormId { get; set; }
        public int? MedicalGroupId { get; set; }
        public string MedicalGroup { get; set; }
        public int? SubjectId { get; set; }
        public string Subject { get; set; }
        public string Recommendations { get; set; }
        public string RecommendationsDetail { get; set; }
        public string Exercise { get; set; }
        public string ExerciseDetail { get; set; }
        public string UserCreate { get; set; }
        public int UserCreateId { get; set; }
        public int SType { get; set; }
        public bool? Bdel { get; set; }
    }
}

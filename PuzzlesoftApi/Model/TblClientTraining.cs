using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblClientTraining
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime? Date1 { get; set; }
        public int FormId { get; set; }
        public int SubjectId { get; set; }
        public string ReceiveTraining { get; set; }
        public string TrainingMethod { get; set; }
        public string UnderstandingTraining { get; set; }
        public string UnderstandingTrainingOperation { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public bool BDel { get; set; }
        public string Remarks { get; set; }
    }
}

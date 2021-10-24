using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class DietNutritionClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Subject { get; set; }
        public int SubjectId { get; set; }
        public string Val { get; set; }
        public bool Bdel { get; set; }
        public DateTime Tstamp { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
    }
}

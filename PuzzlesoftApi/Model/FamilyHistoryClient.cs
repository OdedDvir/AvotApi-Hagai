using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class FamilyHistoryClient
    {
        public int Id { get; set; }
        public string Kinship { get; set; }
        public int ClientId { get; set; }
        public bool Bdel { get; set; }
        public DateTime Tstamp { get; set; }
        public int UserCreateId { get; set; }
        public string UserCreate { get; set; }
        public string Illness { get; set; }
        public int? Age { get; set; }
        public string Relationship { get; set; }
    }
}

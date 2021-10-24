using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class MedicineGeneric
    {
        public int Id { get; set; }
        public string DrugKod { get; set; }
        public int GenericKod { get; set; }
        public float MinunNum { get; set; }
        public string MinunType { get; set; }
        public bool BDel { get; set; }
    }
}

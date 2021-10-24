using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class DocDesign
    {
        public string ImgPath { get; set; }
        public short Id { get; set; }
        public string LblKod { get; set; }
        public string LblParitName { get; set; }
        public string LblQuantity { get; set; }
        public string LblPrice { get; set; }
        public string LblDiscount { get; set; }
        public string LblTotal { get; set; }
    }
}

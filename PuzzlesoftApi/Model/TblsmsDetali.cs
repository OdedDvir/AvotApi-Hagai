using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblsmsDetali
    {
        public int Id { get; set; }
        public string SMsg { get; set; }
        public string PhoneToSms { get; set; }
        public int UseridSend { get; set; }
        public DateTime TStampCreate { get; set; }
        public int Clientid { get; set; }
        public string ResponseMen { get; set; }
        public bool? BSent { get; set; }
    }
}

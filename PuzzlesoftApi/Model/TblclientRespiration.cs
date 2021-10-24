using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblclientRespiration
    {
        public int Id { get; set; }
        public int Clientid { get; set; }
        public int? RespMachineId { get; set; }
        public string RespMachineName { get; set; }
        public int? RespMethodId { get; set; }
        public string RespMethodName { get; set; }
        public int? RespStatusId { get; set; }
        public string RespStatusName { get; set; }
        public int? RespLevelSupId { get; set; }
        public string RespLevelSupName { get; set; }
        public int? CoughReflexId { get; set; }
        public string CoughReflexName { get; set; }
        public int? QountityProvisionId { get; set; }
        public string QountityProvisionName { get; set; }
        public string Username { get; set; }
        public int? Userid { get; set; }
        public DateTime? Tstamp { get; set; }
        public int? UseridDel { get; set; }
        public bool? Bdel { get; set; }
    }
}

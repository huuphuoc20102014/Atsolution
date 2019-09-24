using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscAudittingLog
    {
        public string EventId { get; set; }
        public string LoginName { get; set; }
        public string ComputerName { get; set; }
        public string ComputerIp { get; set; }
        public string ApplicationPartAlias { get; set; }
        public string PermissionTypeAlias { get; set; }
        public DateTime? Time { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string RefId { get; set; }
        public int? RefType { get; set; }
        public string UserId { get; set; }
        public string BranchId { get; set; }
        public string ReferenceManagement { get; set; }
        public string IsWorkingWithManagementBook { get; set; }
        public string ApplicationPartCode { get; set; }
        public string Parameter { get; set; }
    }
}

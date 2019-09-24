using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscAccountObjectJoinRole
    {
        public string UserJoinRoleId { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string BranchId { get; set; }
        public string BranchCode { get; set; }
    }
}

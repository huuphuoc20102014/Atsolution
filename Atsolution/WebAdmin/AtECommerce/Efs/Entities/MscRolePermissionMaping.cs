using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscRolePermissionMaping
    {
        public string Id { get; set; }
        public string SubSystemCode { get; set; }
        public string RoleId { get; set; }
        public string PermissionId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscRole
    {
        public string RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool IsSystem { get; set; }
    }
}

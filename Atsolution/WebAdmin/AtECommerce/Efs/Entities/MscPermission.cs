using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscPermission
    {
        public string PermissionId { get; set; }
        public string PermissionAlias { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
    }
}

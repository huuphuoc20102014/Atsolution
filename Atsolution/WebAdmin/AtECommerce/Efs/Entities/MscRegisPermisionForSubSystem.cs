using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscRegisPermisionForSubSystem
    {
        public string Id { get; set; }
        public string SubSystemCode { get; set; }
        public string PermissionId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class ContractStatus
    {
        public int ContractStatusId { get; set; }
        public string ContractStatusName { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool IsSystem { get; set; }
        public int SortOrder { get; set; }
    }
}

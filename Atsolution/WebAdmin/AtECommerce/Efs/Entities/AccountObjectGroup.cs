using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountObjectGroup
    {
        public string AccountObjectGroupId { get; set; }
        public string AccountObjectGroupCode { get; set; }
        public string AccountObjectGroupName { get; set; }
        public string ParentId { get; set; }
        public string MisacodeId { get; set; }
        public int? Grade { get; set; }
        public bool IsParent { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool IsSystem { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SortMisacodeId { get; set; }
        public int GroupType { get; set; }
    }
}

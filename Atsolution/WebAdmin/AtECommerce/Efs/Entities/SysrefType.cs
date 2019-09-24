using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class SysrefType
    {
        public int RefType { get; set; }
        public string RefTypeName { get; set; }
        public int? RefTypeCategory { get; set; }
        public string MasterTableName { get; set; }
        public string DetailTableName { get; set; }
        public bool Postable { get; set; }
        public bool Searchable { get; set; }
        public int SortOrder { get; set; }
        public string SubSystem { get; set; }
        public int? PostType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsShowOnAccountDefault { get; set; }
        public string Description { get; set; }
        public bool? IsReference { get; set; }

        public virtual SysrefTypeCategory RefTypeCategoryNavigation { get; set; }
    }
}

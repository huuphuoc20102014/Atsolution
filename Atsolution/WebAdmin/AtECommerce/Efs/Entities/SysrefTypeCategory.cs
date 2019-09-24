using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class SysrefTypeCategory
    {
        public SysrefTypeCategory()
        {
            SysrefType = new HashSet<SysrefType>();
        }

        public int RefTypeCategory { get; set; }
        public string RefTypeCategoryName { get; set; }
        public string DefaultDebitAccountId { get; set; }
        public string DefaultCreditAccountId { get; set; }
        public bool UseRebuildRefNo { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SysrefType> SysrefType { get; set; }
    }
}

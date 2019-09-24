using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class VoucherTypeCategory
    {
        public int VoucherTypeCategory1 { get; set; }
        public string VoucherTypeCategoryName { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class VoucherTypeCategoryRefType
    {
        public string Id { get; set; }
        public int? VoucherTypeCategory { get; set; }
        public int? RefType { get; set; }
    }
}

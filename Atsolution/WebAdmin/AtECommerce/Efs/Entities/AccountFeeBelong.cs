using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountFeeBelong
    {
        public string Id { get; set; }
        public string FeeCode { get; set; }
        public string FeeName { get; set; }
        public bool InActive { get; set; }
        public string BelongScreen { get; set; }
        public int SortIndex { get; set; }
        public string UnsignName { get; set; }
    }
}

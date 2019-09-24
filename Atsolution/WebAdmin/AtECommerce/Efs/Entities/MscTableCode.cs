using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscTableCode
    {
        public string TableId { get; set; }
        public string TableCode { get; set; }
        public decimal CurrentValue { get; set; }
        public string TableName { get; set; }
        public string Prefix { get; set; }
        public int? Lenght { get; set; }
        public string UnsignName { get; set; }
    }
}

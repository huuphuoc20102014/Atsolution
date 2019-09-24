using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WProductAndTag
    {
        public string FkWproduct { get; set; }
        public string FkTag { get; set; }
        public int ShowIndex { get; set; }
    }
}

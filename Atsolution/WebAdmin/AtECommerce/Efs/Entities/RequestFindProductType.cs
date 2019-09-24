using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProductType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int StatusChange { get; set; }
    }
}

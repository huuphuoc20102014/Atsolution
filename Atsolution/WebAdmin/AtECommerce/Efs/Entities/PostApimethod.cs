using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class PostApimethod
    {
        public string Id { get; set; }
        public string MethodName { get; set; }
        public string Apiline { get; set; }
        public bool InActive { get; set; }
    }
}

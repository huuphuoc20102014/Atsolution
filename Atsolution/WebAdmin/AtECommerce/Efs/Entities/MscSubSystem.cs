using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscSubSystem
    {
        public string SubSystemCode { get; set; }
        public string SubSystemName { get; set; }
        public string Description { get; set; }
        public string ParentSubSystemCode { get; set; }
        public int? SortOrder { get; set; }
        public int? SystemType { get; set; }
        public string SubSystemSerial { get; set; }
    }
}

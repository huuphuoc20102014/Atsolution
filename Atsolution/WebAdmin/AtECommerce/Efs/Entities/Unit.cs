using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Unit
    {
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}

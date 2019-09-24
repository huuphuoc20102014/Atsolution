using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Port
    {
        public string Id { get; set; }
        public string PortName { get; set; }
        public string PortAddress { get; set; }
        public string PortNameUnsign { get; set; }
    }
}

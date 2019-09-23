using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class Setting
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool? IsManual { get; set; }
    }
}

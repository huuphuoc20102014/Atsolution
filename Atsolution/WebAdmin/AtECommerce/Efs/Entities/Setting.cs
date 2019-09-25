using System;
using System.Collections.Generic;

namespace AtECommerce.Efs.Entities
{
    public partial class Setting : AtBaseECommerceEntity
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool? IsManual { get; set; }
    }
}

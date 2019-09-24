using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WColorOfProduct
    {
        public string Id { get; set; }
        public string ColorName { get; set; }
        public string ColorImage { get; set; }
        public bool Acitive { get; set; }
    }
}

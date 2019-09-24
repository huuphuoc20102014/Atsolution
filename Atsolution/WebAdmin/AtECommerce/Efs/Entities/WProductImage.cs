using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WProductImage
    {
        public string Id { get; set; }
        public string FkWproduct { get; set; }
        public string ImagePath { get; set; }
        public int ShowIndex { get; set; }
    }
}

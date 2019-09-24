using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WSlideShow
    {
        public string Id { get; set; }
        public string SlideShowGroup { get; set; }
        public string NameSlideShow { get; set; }
        public string ImagePath { get; set; }
        public int ShowIndex { get; set; }
        public bool Acitive { get; set; }
    }
}

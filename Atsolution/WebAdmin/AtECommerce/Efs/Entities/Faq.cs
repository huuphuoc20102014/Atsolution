﻿using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Faq
    {
        public string Id { get; set; }
        public string Faqquestion { get; set; }
        public string Faqreply { get; set; }
        public int ShowIndex { get; set; }
        public bool Active { get; set; }
    }
}

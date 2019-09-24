using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WReviewOfProduct
    {
        public string Id { get; set; }
        public string FkWproduct { get; set; }
        public string ReviewName { get; set; }
        public string ReviewContent { get; set; }
        public int Rating { get; set; }
        public int ShowIndex { get; set; }
        public bool? CheckReview { get; set; }
        public DateTime? DateReview { get; set; }
    }
}

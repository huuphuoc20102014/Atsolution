using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WBlogCaterogy
    {
        public string Id { get; set; }
        public string BlogCategoryName { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDes { get; set; }
        public int ShowIndex { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}

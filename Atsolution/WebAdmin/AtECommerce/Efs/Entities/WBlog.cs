using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WBlog
    {
        public string Id { get; set; }
        public string FkBlogCaterogy { get; set; }
        public string BlogName { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDes { get; set; }
        public string BlogDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int ShowIndex { get; set; }
        public int BlogView { get; set; }
        public string BlogImage { get; set; }
        public string BlogAuthor { get; set; }
        public bool Acitive { get; set; }
    }
}

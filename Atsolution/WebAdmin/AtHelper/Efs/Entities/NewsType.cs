﻿using System;
using System.Collections.Generic;

namespace AtHelper.Efs.Entities
{
    public partial class NewsType
    {
        public NewsType()
        {
            News = new HashSet<News>();
        }

        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Slug_Name { get; set; }
        public bool AutoSlug { get; set; }
        public string Tags { get; set; }
        public string KeyWord { get; set; }
        public string MetaData { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public int RowStatus { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}

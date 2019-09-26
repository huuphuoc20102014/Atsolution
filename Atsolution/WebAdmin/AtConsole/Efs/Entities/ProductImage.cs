using System;
using System.Collections.Generic;

namespace AtConsole.Efs.Entities
{
    public partial class ProductImage
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
        public string FkProductId { get; set; }
        public string Extension { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public int RowStatus { get; set; }

        public virtual Product FkProduct { get; set; }
    }
}

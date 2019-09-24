using System;
using System.Collections.Generic;

namespace AtConsole.Efs.Entities
{
    public partial class Product
    {
        public Product()
        {
            ProductImage = new HashSet<ProductImage>();
        }

        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool AutoSlug { get; set; }
        public int Status { get; set; }
        public string FkProductId { get; set; }
        public string Specification { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Tags { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public int RowStatus { get; set; }

        public virtual Category FkProduct { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AtConsole.Efs.Entities
{
    public partial class Category
    {
        public Category()
        {
            InverseFkParent = new HashSet<Category>();
            Product = new HashSet<Product>();
        }

        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool AutoSlug { get; set; }
        public int Status { get; set; }
        public string FkParentId { get; set; }
        public int Rank { get; set; }
        public int ThuTu { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public int RowStatus { get; set; }
        public int CountChild { get; set; }
        public int CountProduct { get; set; }

        public virtual Category FkParent { get; set; }
        public virtual ICollection<Category> InverseFkParent { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}

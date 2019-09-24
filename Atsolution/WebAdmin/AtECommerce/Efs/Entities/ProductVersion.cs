using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class ProductVersion
    {
        public ProductVersion()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }
        public string FkProductId { get; set; }
        public string FkInventoryItemDetail { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }

        public virtual Product FkProduct { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}

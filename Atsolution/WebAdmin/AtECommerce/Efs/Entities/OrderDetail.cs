using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class OrderDetail
    {
        public string Id { get; set; }
        public string FkOrder { get; set; }
        public string FkProductDetail { get; set; }
        public int SortIndex { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ProductVerion { get; set; }

        public virtual Order FkOrderNavigation { get; set; }
        public virtual ProductVersion FkProductDetailNavigation { get; set; }
    }
}

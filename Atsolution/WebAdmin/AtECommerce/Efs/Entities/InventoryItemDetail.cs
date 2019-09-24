using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class InventoryItemDetail
    {
        public InventoryItemDetail()
        {
            StockImportOrExportDetail = new HashSet<StockImportOrExportDetail>();
            StockInventoryItemDetail = new HashSet<StockInventoryItemDetail>();
        }

        public string Id { get; set; }
        public string InventoryDetailCode { get; set; }
        public string FkInventoryItemId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public string Sku { get; set; }
        public bool IsOnlineItem { get; set; }
        public bool IsMaterial { get; set; }
        public string ParentInventoryItem { get; set; }

        public virtual ICollection<StockImportOrExportDetail> StockImportOrExportDetail { get; set; }
        public virtual ICollection<StockInventoryItemDetail> StockInventoryItemDetail { get; set; }
    }
}

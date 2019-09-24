using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class StockImportOrExportDetail
    {
        public string Id { get; set; }
        public string FkInventoryItemDetailId { get; set; }
        public string FkStockImporOrExporttId { get; set; }
        public int SortIndex { get; set; }
        public string InventoryName { get; set; }
        public string Code { get; set; }
        public string Unit { get; set; }
        public decimal ActualQuantity { get; set; }
        public decimal PlanQuantity { get; set; }
        public string UnitPrice { get; set; }
        public decimal TotalAmountWithOutTax { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TaxAmount { get; set; }
        public string Lot { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string FkInventoryItem { get; set; }
        public string FkStockInventoryItemDetail { get; set; }
        public decimal? RealityAmountInStock { get; set; }

        public virtual InventoryItemDetail FkInventoryItemDetail { get; set; }
        public virtual StockImportOrExport FkStockImporOrExportt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class StockInventoryItemDetail
    {
        public string Id { get; set; }
        public string FkStockId { get; set; }
        public string FkInventoryItemDetail { get; set; }
        public decimal RealityAmount { get; set; }
        public decimal ImportAmount { get; set; }
        public decimal ExportAmount { get; set; }
        public decimal InitAmount { get; set; }
        public string Lot { get; set; }
        public DateTime ExperiedDate { get; set; }
        public string FkInventoryItem { get; set; }

        public virtual InventoryItemDetail FkInventoryItemDetailNavigation { get; set; }
        public virtual Stock FkStock { get; set; }
    }
}

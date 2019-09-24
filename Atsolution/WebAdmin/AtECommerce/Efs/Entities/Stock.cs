using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Stock
    {
        public Stock()
        {
            StockImportOrExport = new HashSet<StockImportOrExport>();
            StockInventoryItemDetail = new HashSet<StockInventoryItemDetail>();
        }

        public string StockId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string InventoryAccount { get; set; }
        public string BranchId { get; set; }

        public virtual ICollection<StockImportOrExport> StockImportOrExport { get; set; }
        public virtual ICollection<StockInventoryItemDetail> StockInventoryItemDetail { get; set; }
    }
}

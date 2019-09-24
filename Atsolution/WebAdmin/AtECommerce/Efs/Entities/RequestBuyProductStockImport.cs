using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductStockImport
    {
        public string Id { get; set; }
        public string FkRequestBuyProduct { get; set; }
        public string FkInventoryItemDetail { get; set; }
        public string Lot { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal PlanQuantity { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? IsMaterial { get; set; }
    }
}

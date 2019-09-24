using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class InventoryItemGeneral
    {
        public string Id { get; set; }
        public int Serial { get; set; }
        public string FkInventoryItem { get; set; }
        public string FkInventotyDetail { get; set; }
        public string Lot { get; set; }
        public DateTime? Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal PlanQuantity { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsMaterial { get; set; }
    }
}

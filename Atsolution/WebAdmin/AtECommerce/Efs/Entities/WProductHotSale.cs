using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WProductHotSale
    {
        public string Id { get; set; }
        public string WProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductPriceSale { get; set; }
        public DateTime DateSales { get; set; }
        public DateTime DateEnd { get; set; }
        public int Avaible { get; set; }
        public int Sold { get; set; }
        public bool? Active { get; set; }
        public int ShowIndex { get; set; }
    }
}

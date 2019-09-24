using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductProviderMaterial
    {
        public string Id { get; set; }
        public string FkRequestBuyProductProvider { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public bool IsDelete { get; set; }

        public virtual RequestBuyProductProvider FkRequestBuyProductProviderNavigation { get; set; }
    }
}

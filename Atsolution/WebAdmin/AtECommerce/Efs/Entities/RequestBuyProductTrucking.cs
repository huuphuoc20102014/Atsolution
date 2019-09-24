using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductTrucking
    {
        public string Id { get; set; }
        public string FkRequestBuyProduct { get; set; }
        public string FkProvider { get; set; }
        public string FkDestinationPort { get; set; }
        public string AddressLoadGood { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal Price { get; set; }
        public decimal AnotherCost { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FkUserUpdate { get; set; }
        public int MainProvider { get; set; }
        public int ApproverMainProvider { get; set; }

        public virtual RequestBuyProduct FkRequestBuyProductNavigation { get; set; }
    }
}

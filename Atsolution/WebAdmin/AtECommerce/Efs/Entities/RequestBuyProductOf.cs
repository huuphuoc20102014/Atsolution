using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductOf
    {
        public string Id { get; set; }
        public string FkRequestBuyProduct { get; set; }
        public string FkProvider { get; set; }
        public string FkSourcePort { get; set; }
        public string FkDestinationPort { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal Exwprice { get; set; }
        public decimal Ofprice { get; set; }
        public decimal Lcprice { get; set; }
        public int BookBeforeDays { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FkUserUpdate { get; set; }
        public int MainProvider { get; set; }
        public int ApproverMainProvider { get; set; }
        public bool IsBorderTrade { get; set; }
        public decimal BorderShippingPrice { get; set; }
        public string FkProviderLc { get; set; }

        public virtual RequestBuyProduct FkRequestBuyProductNavigation { get; set; }
    }
}

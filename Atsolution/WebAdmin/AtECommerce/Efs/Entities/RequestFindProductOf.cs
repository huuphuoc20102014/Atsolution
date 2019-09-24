using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProductOf
    {
        public string Id { get; set; }
        public string FkRequestFindProduct { get; set; }
        public string FkProviderLc { get; set; }
        public string FkProvider { get; set; }
        public string FkSourcePort { get; set; }
        public string FkDestinationPort { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DemoExwprice { get; set; }
        public decimal MoqExwprice { get; set; }
        public decimal Dc20exwprice { get; set; }
        public decimal Dc40exwprice { get; set; }
        public decimal Dc40hexwprice { get; set; }
        public decimal DemoPrice { get; set; }
        public decimal MoqPrice { get; set; }
        public decimal Dc20price { get; set; }
        public decimal Dc40price { get; set; }
        public decimal Dc40hprice { get; set; }
        public decimal DemoLcprice { get; set; }
        public decimal MoqLcprice { get; set; }
        public decimal Dc20lcprice { get; set; }
        public decimal Dc40lcprice { get; set; }
        public decimal Dc40hlcprice { get; set; }
        public int BookBeforeDays { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FkUserUpdate { get; set; }
        public int IndexProvider { get; set; }
        public int MainProvider { get; set; }
        public int ApproverMainProvider { get; set; }
        public bool IsBorderTradeDemo { get; set; }
        public decimal DemoShippingPrice { get; set; }
        public bool IsBorderTradeMoq { get; set; }
        public decimal MoqShippingPrice { get; set; }

        public virtual RequestFindProduct FkRequestFindProductNavigation { get; set; }
    }
}

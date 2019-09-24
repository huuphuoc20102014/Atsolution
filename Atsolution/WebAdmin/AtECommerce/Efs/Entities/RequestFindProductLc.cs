using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProductLc
    {
        public string Id { get; set; }
        public string FkRequestFindProduct { get; set; }
        public string FkProvider { get; set; }
        public string FkSourcePort { get; set; }
        public string AddressLoadGood { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DemoCost { get; set; }
        public decimal MoqCost { get; set; }
        public decimal Dc20cost { get; set; }
        public decimal Dc40cost { get; set; }
        public decimal Dc40hcost { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FkUserUpdate { get; set; }
        public int IndexProvider { get; set; }
        public int MainProvider { get; set; }
        public int ApproverMainProvider { get; set; }

        public virtual RequestFindProduct FkRequestFindProductNavigation { get; set; }
    }
}

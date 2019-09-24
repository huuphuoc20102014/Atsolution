using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProductCustoms
    {
        public string Id { get; set; }
        public string FkRequestFindProduct { get; set; }
        public string FkProvider { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DemoCost { get; set; }
        public decimal MoqCost { get; set; }
        public decimal Dc20cost { get; set; }
        public decimal Dc40cost { get; set; }
        public decimal Dc40hcost { get; set; }
        public decimal DemoImportTax { get; set; }
        public decimal MoqImportTax { get; set; }
        public decimal Dc20importTax { get; set; }
        public decimal Dc40importTax { get; set; }
        public decimal Dc40himportTax { get; set; }
        public decimal DemoVatTax { get; set; }
        public decimal MoqVatTax { get; set; }
        public decimal Dc20vatTax { get; set; }
        public decimal Dc40vatTax { get; set; }
        public decimal Dc40hvatTax { get; set; }
        public decimal InspectionCost { get; set; }
        public decimal PublicationCost { get; set; }
        public decimal AnotherCost { get; set; }
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

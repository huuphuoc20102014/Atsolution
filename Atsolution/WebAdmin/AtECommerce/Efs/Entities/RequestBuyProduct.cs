using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProduct
    {
        public RequestBuyProduct()
        {
            RequestBuyProductCustoms = new HashSet<RequestBuyProductCustoms>();
            RequestBuyProductOf = new HashSet<RequestBuyProductOf>();
            RequestBuyProductPayOrder = new HashSet<RequestBuyProductPayOrder>();
            RequestBuyProductProvider = new HashSet<RequestBuyProductProvider>();
            RequestBuyProductTrucking = new HashSet<RequestBuyProductTrucking>();
        }

        public string Id { get; set; }
        public string RequestCode { get; set; }
        public string ProductName { get; set; }
        public int FkStatus { get; set; }
        public string FkUserSale { get; set; }
        public DateTime RequestDate { get; set; }
        public string FkRequestFindProduct { get; set; }
        public string FkInventoryItem { get; set; }
        public string FkProvine { get; set; }
        public string DeliveryAddress { get; set; }
        public int? WarrantyMonth { get; set; }
        public DateTime DateNeedGood { get; set; }
        public string SalePlan { get; set; }
        public string FkCustomer { get; set; }
        public decimal Quantity { get; set; }
        public int ContainerType { get; set; }
        public decimal QuantityContainer { get; set; }
        public decimal SalePrice { get; set; }
        public int? ContractType { get; set; }
        public int? FkTypeOfBuy { get; set; }
        public int? BuyType { get; set; }
        public string TradeMark { get; set; }
        public string DesignTradeMarkFile { get; set; }
        public string AdditionalLabel { get; set; }
        public string Note { get; set; }
        public string FkUserSaleLeader { get; set; }
        public string SaleLeadeApprover { get; set; }
        public DateTime? SaleLeadApproverDate { get; set; }
        public string SaleLeadapproverNote { get; set; }
        public string FkUserPurchaseAcc { get; set; }
        public DateTime? PurchaseAccDate { get; set; }
        public string PurchaseAccNote { get; set; }
        public string FkUserChiefAcc { get; set; }
        public DateTime? ChiefAccDate { get; set; }
        public string ChiefAccNote { get; set; }
        public string FkUserSourceProcess { get; set; }
        public DateTime? SourceProcessDate { get; set; }
        public string FkUserSourceApprover { get; set; }
        public DateTime? SourceApproverDate { get; set; }
        public string SourApproverNote { get; set; }
        public string FkUserFlorder { get; set; }
        public DateTime? FlorderDate { get; set; }
        public string FkUserCashAcc { get; set; }
        public int? FactoryProgressPercent { get; set; }
        public DateTime? FactoryFinishDate { get; set; }
        public DateTime? CashAccDate { get; set; }
        public string CashAccNote { get; set; }
        public DateTime? CashAccPayPlan { get; set; }
        public string FkUserChiefCashAcc { get; set; }
        public DateTime? ChiefCashDate { get; set; }
        public string ChiefCashNote { get; set; }
        public string FkUserOfprocess { get; set; }
        public DateTime? OfprocessDate { get; set; }
        public string FkUserCustomsProcess { get; set; }
        public DateTime? CustomsProcessDate { get; set; }
        public string FkUserTruckingProcess { get; set; }
        public DateTime? TruckingProcessDate { get; set; }
        public string FkUserWareHouseAcc { get; set; }
        public DateTime? WareHouseAccDate { get; set; }
        public string WareHouseAccNote { get; set; }
        public string FkUserChiefWareHouseAcc { get; set; }
        public DateTime? ChiefWareHouseAccDate { get; set; }
        public int IsDelete { get; set; }

        public virtual ICollection<RequestBuyProductCustoms> RequestBuyProductCustoms { get; set; }
        public virtual ICollection<RequestBuyProductOf> RequestBuyProductOf { get; set; }
        public virtual ICollection<RequestBuyProductPayOrder> RequestBuyProductPayOrder { get; set; }
        public virtual ICollection<RequestBuyProductProvider> RequestBuyProductProvider { get; set; }
        public virtual ICollection<RequestBuyProductTrucking> RequestBuyProductTrucking { get; set; }
    }
}

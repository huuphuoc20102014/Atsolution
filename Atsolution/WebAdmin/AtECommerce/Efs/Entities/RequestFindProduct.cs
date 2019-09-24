using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProduct
    {
        public RequestFindProduct()
        {
            RequestFindProductCustoms = new HashSet<RequestFindProductCustoms>();
            RequestFindProductLc = new HashSet<RequestFindProductLc>();
            RequestFindProductOf = new HashSet<RequestFindProductOf>();
            RequestFindProductProvider = new HashSet<RequestFindProductProvider>();
            RequestFindProductTrucking = new HashSet<RequestFindProductTrucking>();
        }

        public string Id { get; set; }
        public string RequestCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductNameUnsign { get; set; }
        public string RequestImage { get; set; }
        public DateTime BeginRequestDate { get; set; }
        public string FkInventoryCategory { get; set; }
        public string FkProvine { get; set; }
        public string DeliveryAddress { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string FkUnit { get; set; }
        public decimal QuantityOfPacking { get; set; }
        public string Packing { get; set; }
        public int WarrantyMonth { get; set; }
        public string TradeMark { get; set; }
        public string DesignTradeMarkFile { get; set; }
        public string AdditionalLabel { get; set; }
        public DateTime EndRequestDate { get; set; }
        public string RequestNote { get; set; }
        public bool IsCustomerRequest { get; set; }
        public string FkUserSaleRequest { get; set; }
        public int HeightX { get; set; }
        public int WidthY { get; set; }
        public int ThicknessZ { get; set; }
        public decimal Weight { get; set; }
        public string FkWeightUnit { get; set; }
        public int FkStatus { get; set; }
        public string FkUserRequestApprover { get; set; }
        public DateTime? UserRequestApproverDate { get; set; }
        public string RequestApproverNote { get; set; }
        public string FkUserSourceProcess { get; set; }
        public DateTime? SourceProcessDate { get; set; }
        public string FkUserSourceApprover { get; set; }
        public DateTime? SourceApproverDate { get; set; }
        public string SourceApproverNote { get; set; }
        public string FkUserSourceEstimator { get; set; }
        public DateTime? SourceEstimator { get; set; }
        public string SourceEstimatorNote { get; set; }
        public bool IsLcofdone { get; set; }
        public string FkUserLcofprocess { get; set; }
        public DateTime? Lcofdate { get; set; }
        public bool IsCustomsDone { get; set; }
        public string FkUserCustomsProcess { get; set; }
        public DateTime? CustomsProcessDate { get; set; }
        public bool IsTruckingDone { get; set; }
        public string FkUserTruckingProcess { get; set; }
        public DateTime? TruckingProcessDate { get; set; }
        public string FkOpapprover { get; set; }
        public DateTime? OpapproverDate { get; set; }
        public string OpapproverNote { get; set; }
        public bool IsApproverLcof { get; set; }
        public bool IsApproverCustoms { get; set; }
        public bool IsApproverTrucking { get; set; }
        public string FkOpestimator { get; set; }
        public DateTime? OpestimatorDate { get; set; }
        public string OpestimatorNote { get; set; }
        public bool IsEstimatorLcof { get; set; }
        public bool IsEstimatorCustoms { get; set; }
        public bool IsEstimatorTrucking { get; set; }
        public bool IsReceptionLcof { get; set; }
        public bool IsReceptionCustoms { get; set; }
        public bool IsReceptionTrucking { get; set; }
        public decimal DemoTransferCost { get; set; }
        public decimal DemoCost { get; set; }
        public decimal MoqTransferCost { get; set; }
        public decimal MoqCost { get; set; }
        public decimal Dc20transferCost { get; set; }
        public decimal Dc20cost { get; set; }
        public decimal Dc40transferCost { get; set; }
        public decimal Dc40cost { get; set; }
        public decimal Dc40htransferCost { get; set; }
        public decimal Dc40hcost { get; set; }
        public decimal DemoWholesaleCost { get; set; }
        public decimal MoqWholesaleCost { get; set; }
        public decimal Dc20wholesaleCost { get; set; }
        public decimal Dc40wholesaleCost { get; set; }
        public decimal Dc40hwholesaleCost { get; set; }
        public decimal DemoRetailCost { get; set; }
        public decimal MoqRetailCost { get; set; }
        public decimal Dc20retailCost { get; set; }
        public decimal Dc40retailCost { get; set; }
        public decimal Dc40hretailCost { get; set; }
        public int DemoWholesalePercent { get; set; }
        public int MoqWholesalePercent { get; set; }
        public int Dc20wholesalePercent { get; set; }
        public int Dc40wholesalePercent { get; set; }
        public int Dc40hwholesalePercent { get; set; }
        public int DemoRetailPercent { get; set; }
        public int MoqRetailPercent { get; set; }
        public int Dc20retailPercent { get; set; }
        public int Dc40retailPercent { get; set; }
        public int Dc40hretailPercent { get; set; }
        public decimal DemoWholesalePrice { get; set; }
        public decimal MoqWholesalePrice { get; set; }
        public decimal Dc20wholesalePrice { get; set; }
        public decimal Dc40wholesalePrice { get; set; }
        public decimal Dc40hwholesalePrice { get; set; }
        public decimal DemoRetailPrice { get; set; }
        public decimal MoqRetailPrice { get; set; }
        public decimal Dc20retailPrice { get; set; }
        public decimal Dc40retailPrice { get; set; }
        public decimal Dc40hretailPrice { get; set; }
        public string FkFinishEstimator { get; set; }
        public DateTime? FinishEstimatorDate { get; set; }
        public string FkInventoryItem { get; set; }
        public string ReferRequestFindProduct { get; set; }
        public int IsDelete { get; set; }
        public int? FkTypeOfRequest { get; set; }
        public bool IsBorderTradeDemo { get; set; }
        public decimal? DemoShippingPrice { get; set; }
        public bool IsBorderTradeMoq { get; set; }
        public decimal? MoqShippingPrice { get; set; }
        public bool IsSkipAllStep { get; set; }
        public string WeightFrom { get; set; }
        public string WeightTo { get; set; }
        public bool IsNetWeight { get; set; }
        public decimal WishPrice { get; set; }
        public string FkUnitPacking { get; set; }
        public int? FkRequestPrioty { get; set; }

        public virtual RequestFindProductStatus FkStatusNavigation { get; set; }
        public virtual ICollection<RequestFindProductCustoms> RequestFindProductCustoms { get; set; }
        public virtual ICollection<RequestFindProductLc> RequestFindProductLc { get; set; }
        public virtual ICollection<RequestFindProductOf> RequestFindProductOf { get; set; }
        public virtual ICollection<RequestFindProductProvider> RequestFindProductProvider { get; set; }
        public virtual ICollection<RequestFindProductTrucking> RequestFindProductTrucking { get; set; }
    }
}

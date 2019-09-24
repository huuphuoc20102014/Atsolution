using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class InventoryItem
    {
        public InventoryItem()
        {
            Product = new HashSet<Product>();
        }

        public string InventoryItemId { get; set; }
        public string BranchId { get; set; }
        public string BarCode { get; set; }
        public string InventoryItemCode { get; set; }
        public string InventoryItemName { get; set; }
        public int? InventoryItemType { get; set; }
        public string InventoryItemCategoryList { get; set; }
        public string InventoryItemCategoryCode { get; set; }
        public string Description { get; set; }
        public string UnitId { get; set; }
        public string GuarantyPeriod { get; set; }
        public decimal MinimumStock { get; set; }
        public string InventoryItemSource { get; set; }
        public string DefaultStockId { get; set; }
        public string InventoryAccount { get; set; }
        public string Cogsaccount { get; set; }
        public string SaleAccount { get; set; }
        public decimal PurchaseDiscountRate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SalePrice1 { get; set; }
        public decimal SalePrice2 { get; set; }
        public decimal SalePrice3 { get; set; }
        public decimal FixedSalePrice { get; set; }
        public bool IsUnitPriceAfterTax { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? ImportTaxRate { get; set; }
        public decimal? ExportTaxRate { get; set; }
        public string InventoryCategorySpecialTaxId { get; set; }
        public bool IsSystem { get; set; }
        public bool Inactive { get; set; }
        public bool? IsSaleDiscount { get; set; }
        public int? DiscountType { get; set; }
        public bool? IsFollowSerialNumber { get; set; }
        public int? CostMethod { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string InventoryItemCategoryName { get; set; }
        public string Specificity { get; set; }
        public string PurchaseDescription { get; set; }
        public string SaleDescription { get; set; }
        public int? TacareerGroupId { get; set; }
        public byte[] Image { get; set; }
        public decimal FixedUnitPrice { get; set; }
        public string FrontEndFormula { get; set; }
        public string BackEndFormula { get; set; }
        public int? BaseOnFormula { get; set; }
        public string DiscountAccount { get; set; }
        public string SaleOffAccount { get; set; }
        public string ReturnAccount { get; set; }
        public bool IsMaterial { get; set; }
        public string ParentInventoryItem { get; set; }
        public string Sku { get; set; }
        public string TradeMark { get; set; }
        public string Model { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}

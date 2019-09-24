using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountObjectLedger
    {
        public int AccountObjectLedgerId { get; set; }
        public string BranchId { get; set; }
        public string RefId { get; set; }
        public string RefDetailId { get; set; }
        public int EntryType { get; set; }
        public int RefType { get; set; }
        public string RefNo { get; set; }
        public DateTime RefDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string InvRefId { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string InvSeries { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string CorrespondingAccountNumber { get; set; }
        public decimal ExchangeRate { get; set; }
        public string CurrencyId { get; set; }
        public string UnitId { get; set; }
        public decimal UnitPriceOc { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal DebitAmountOc { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmountOc { get; set; }
        public decimal CreditAmount { get; set; }
        public string JournalMemo { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string OrganizationUnitId { get; set; }
        public string AccountObjectId { get; set; }
        public string AccountObjectCode { get; set; }
        public string AccountObjectName { get; set; }
        public string AccountObjectNameDi { get; set; }
        public string AccountObjectTaxCode { get; set; }
        public string AccountObjectAddress { get; set; }
        public string AccountObjectAddressDi { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string OrderId { get; set; }
        public string JobId { get; set; }
        public string ContractId { get; set; }
        public DateTime? ContractSignDate { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ListItemId { get; set; }
        public string BudgetItemId { get; set; }
        public string ProjectWorkId { get; set; }
        public string PaymentTermId { get; set; }
        public string InventoryItemId { get; set; }
        public string InventoryItemCode { get; set; }
        public string InventoryItemName { get; set; }
        public string PucontractId { get; set; }
        public DateTime? PusignDate { get; set; }
        public string PucontractCode { get; set; }
        public string PucontractName { get; set; }
        public string RefTypeName { get; set; }
        public bool IsPostToManagementBook { get; set; }
        public int? RefOrder { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsUpdateRedundant { get; set; }
        public string PuorderRefId { get; set; }
        public string MainUnitId { get; set; }
        public decimal MainUnitPrice { get; set; }
        public decimal MainQuantity { get; set; }
        public decimal MainConvertRate { get; set; }
        public string ExchangeRateOperator { get; set; }
        public string DocumentIncluded { get; set; }
        public int? DetailPostOrder { get; set; }
        public decimal? MainUnitPriceOc { get; set; }
        public decimal? CashOutExchangeRateLedger { get; set; }
        public int? BusinessType { get; set; }
    }
}

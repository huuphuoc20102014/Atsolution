using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Contract
    {
        public string ContractId { get; set; }
        public string BranchId { get; set; }
        public bool IsProject { get; set; }
        public string ProjectId { get; set; }
        public string ContractCode { get; set; }
        public DateTime? SignDate { get; set; }
        public string ContractSubject { get; set; }
        public string CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal ContractAmountOc { get; set; }
        public decimal ContractAmount { get; set; }
        public decimal CloseAmountOc { get; set; }
        public decimal CloseAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool IsArisedBeforeUseSoftware { get; set; }
        public decimal ExpenseAmountFinance { get; set; }
        public decimal ReceiptAmountOcfinance { get; set; }
        public decimal ReceiptAmountFinance { get; set; }
        public decimal InvoiceAmountOcfinance { get; set; }
        public decimal InvoiceAmountFinance { get; set; }
        public string AccountObjectId { get; set; }
        public string AccountObjectAddress { get; set; }
        public string AccountObjectContactName { get; set; }
        public string OrganizationUnitId { get; set; }
        public string EmployeeId { get; set; }
        public int? ContractStatusId { get; set; }
        public DateTime? CloseDate { get; set; }
        public string CloseReason { get; set; }
        public int? RevenueStatus { get; set; }
        public string OtherTerms { get; set; }
        public bool IsCalculatedCost { get; set; }
        public bool IsInvoiced { get; set; }
        public DateTime? RevenueDate { get; set; }
        public decimal TotalExpenseExpectAmount { get; set; }
        public decimal TotalExpensedAmount { get; set; }
        public decimal BalanceExpenseAmountFinance { get; set; }
        public decimal TotalReceiptedAmount { get; set; }
        public decimal BalanceReceiptAmountFinance { get; set; }
        public decimal ProfitAndLossExpectAmountFinance { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int RefType { get; set; }
        public string SaorderId { get; set; }
        public bool? IsParent { get; set; }
        public decimal TotalInvoiceAmountFinance { get; set; }
        public decimal TotalInvoiceAmountManagement { get; set; }
        public decimal? AccumSaleAmountFinance { get; set; }
        public decimal? AccumCostAmountFinance { get; set; }
        public decimal? AccumOtherAmountFinance { get; set; }
        public decimal ExpenseAmountManagement { get; set; }
        public decimal ReceiptAmountOcmanagement { get; set; }
        public decimal ReceiptAmountManagement { get; set; }
        public decimal InvoiceAmountOcmanagement { get; set; }
        public decimal InvoiceAmountManagement { get; set; }
        public decimal AccumSaleAmountManagement { get; set; }
        public decimal AccumCostAmountManagement { get; set; }
        public decimal AccumOtherAmountManagement { get; set; }
        public decimal TotalInvoiceAmountOcfinance { get; set; }
        public decimal TotalInvoiceAmountOcmanagement { get; set; }
        public decimal BalanceReceiptAmountManagement { get; set; }
        public decimal BalanceExpenseAmountManagement { get; set; }
        public decimal ProfitAndLossExpectAmountManagement { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public string CustomField7 { get; set; }
        public string CustomField8 { get; set; }
        public string CustomField9 { get; set; }
        public string CustomField10 { get; set; }
        public string AccountObjectName { get; set; }
    }
}

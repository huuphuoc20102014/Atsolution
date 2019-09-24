using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class CapaymentDetail
    {
        public string RefDetailId { get; set; }
        public string RefId { get; set; }
        public string Description { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public string BankAccountId { get; set; }
        public decimal AmountOc { get; set; }
        public decimal Amount { get; set; }
        public string BudgetItemId { get; set; }
        public string ExpenseItemId { get; set; }
        public string ProjectWorkId { get; set; }
        public string JobId { get; set; }
        public string OrderId { get; set; }
        public string ContractId { get; set; }
        public string AccountObjectId { get; set; }
        public string OrganizationUnitId { get; set; }
        public string ListItemId { get; set; }
        public string DebtAgreementId { get; set; }
        public bool UnResonableCost { get; set; }
        public int? SortOrder { get; set; }
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
        public string PucontractId { get; set; }
        public decimal CashOutAmountFinance { get; set; }
        public decimal CashOutDiffAmountFinance { get; set; }
        public string CashOutDiffAccountNumberFinance { get; set; }
        public decimal CashOutAmountManagement { get; set; }
        public decimal CashOutDiffAmountManagement { get; set; }
        public string CashOutDiffAccountNumberManagement { get; set; }
        public decimal CashOutExchangeRateFinance { get; set; }
        public decimal CashOutExchangeRateManagement { get; set; }
        public int? BusinessType { get; set; }
        public string PuorderRefId { get; set; }
        public string FkAccountFeeBelong { get; set; }
    }
}
